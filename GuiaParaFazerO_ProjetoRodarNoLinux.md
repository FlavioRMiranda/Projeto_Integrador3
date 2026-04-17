Yes. For **this specific project**, the most reliable Fedora workflow is to **stop depending on `xbuild`** and treat it as a **manual Mono build** project instead.

Why: your project is classic WinForms at startup, so Mono can launch it, but `xbuild` on Fedora 42 kept choking on the framework/toolset setup and on the resource file path. Your app also depends on external DLLs like `DraftServer.dll`, `Guna.UI2.dll`, `MultifuncControl.dll`, and `ReaLTaiizor.dll`, and at runtime Mono looks first in the **same folder as the `.exe`**, then `MONO_PATH`, then the GAC.     ([Mono Project][1])

The short version is: **fresh clone is fine**, and the **path does not matter**, as long as you always run the commands from the **project root** and recreate the files the project expects in **relative locations** like `bin/Debug/Tabuleiro.jpg`. Your earlier failure was exactly that missing resource path.

## What to write down for the real project

### 1) Install the Linux side once

```bash
sudo dnf install mono-devel mono-complete mono-winforms libgdiplus nuget gtk2
```

On Fedora 42, `mono-devel` provides tools like `xbuild`, `resgen`, and Mono’s framework/reference files; `mono-winforms` provides `System.Windows.Forms`; and `libgdiplus` is the Mono-side GDI+ implementation used by WinForms drawing. ([Fedora Packages][2])

### 2) Clone the repo fresh

```bash
git clone https://github.com/FlavioRMiranda/Projeto_Integrador3.git
cd Projeto_Integrador3
```

Always do the next steps **from this folder**.

### 3) Restore NuGet packages

```bash
nuget restore Projeto_Integrador3.sln
```

That matters because your compile references package DLLs under `packages/...`, including `Guna.UI2`, `MyReaLTaiizor`, and `ReaLTaiizor`. 

### 4) Make sure the non-NuGet local DLL is present

Your build also references `./DraftServer.dll`, so the repo root needs that file present. If the clone does not include it, you must copy it in manually before building.

Check:

```bash
ls -l DraftServer.dll
```

If that says “No such file”, copy the DLL into the project root.

### 5) Make sure the board image exists where the project expects it

This project’s resources expect `bin/Debug/Tabuleiro.jpg`. That exact missing path was one of your blockers.

Create the output dirs and copy the image:

```bash
mkdir -p bin/Debug obj/Debug
find . -iname 'Tabuleiro.jpg'
cp ./REAL/PATH/Tabuleiro.jpg ./bin/Debug/Tabuleiro.jpg
```

Use the **real path** returned by `find`, not a placeholder.

### 6) Generate the `.resources` files

```bash
resgen Form1.resx obj/Debug/Projeto_Integrador3.Form1.resources
resgen Properties/Resources.resx obj/Debug/Projeto_Integrador3.Properties.Resources.resources
```

### 7) Compile with `mcs`, not `xbuild`

This was the command that actually got your project compiled on Fedora:

```bash
mcs -debug -target:winexe \
  -out:bin/Debug/Projeto_Integrador3.exe \
  Form1.cs Form1.Designer.cs Program.cs \
  Properties/AssemblyInfo.cs Properties/Resources.Designer.cs Properties/Settings.Designer.cs \
  -resource:obj/Debug/Projeto_Integrador3.Form1.resources \
  -resource:obj/Debug/Projeto_Integrador3.Properties.Resources.resources \
  -r:System.Core.dll \
  -r:System.Data.dll \
  -r:System.Data.DataSetExtensions.dll \
  -r:System.Design.dll \
  -r:System.Drawing.dll \
  -r:System.Configuration.dll \
  -r:System.Management.dll \
  -r:System.Net.Http.dll \
  -r:System.Web.dll \
  -r:System.Windows.Forms.dll \
  -r:System.Xml.dll \
  -r:System.Xml.Linq.dll \
  -r:Microsoft.CSharp.dll \
  -r:Microsoft.VisualBasic.dll \
  -r:DraftServer.dll \
  -r:packages/Guna.UI2.WinForms.2.0.4.7/lib/net48/Guna.UI2.dll \
  -r:packages/MyReaLTaiizor.1.1.6/lib/net462/MultifuncControl.dll \
  -r:packages/ReaLTaiizor.3.8.1.5/lib/net48/ReaLTaiizor.dll
```

That compile succeeded for you with only warnings.

### 8) Copy runtime DLLs next to the `.exe`

This is the part that makes it **run reliably**, not just compile. Mono looks first in the executable’s folder for assemblies. ([Mono Project][1])

So after every build, copy the runtime DLLs into `bin/Debug/`:

```bash
cp DraftServer.dll bin/Debug/
cp packages/Guna.UI2.WinForms.2.0.4.7/lib/net48/Guna.UI2.dll bin/Debug/
cp packages/MyReaLTaiizor.1.1.6/lib/net462/MultifuncControl.dll bin/Debug/
cp packages/ReaLTaiizor.3.8.1.5/lib/net48/ReaLTaiizor.dll bin/Debug/
```

This matters because your app compiled, opened, and then crashed with `FileNotFoundException` for `DraftServer` at runtime.

### 9) Run it

```bash
mono bin/Debug/Projeto_Integrador3.exe
```

If you still prefer not to copy DLLs every time, you can use `MONO_PATH`, but putting the DLLs beside the `.exe` is the most predictable setup because that is Mono’s first lookup location. ([Mono Project][1])

---

## The version I’d actually keep in the repo

### `build-linux.sh`

```bash
#!/usr/bin/env bash
set -euo pipefail

cd "$(dirname "$0")"

mkdir -p bin/Debug obj/Debug

nuget restore Projeto_Integrador3.sln

TABULEIRO_PATH="$(find . -iname 'Tabuleiro.jpg' | head -n 1 || true)"
if [[ -z "${TABULEIRO_PATH}" ]]; then
  echo "Erro: Tabuleiro.jpg não foi encontrado."
  exit 1
fi

cp "$TABULEIRO_PATH" bin/Debug/Tabuleiro.jpg

resgen Form1.resx obj/Debug/Projeto_Integrador3.Form1.resources
resgen Properties/Resources.resx obj/Debug/Projeto_Integrador3.Properties.Resources.resources

mcs -debug -target:winexe \
  -out:bin/Debug/Projeto_Integrador3.exe \
  Form1.cs Form1.Designer.cs Program.cs \
  Properties/AssemblyInfo.cs Properties/Resources.Designer.cs Properties/Settings.Designer.cs \
  -resource:obj/Debug/Projeto_Integrador3.Form1.resources \
  -resource:obj/Debug/Projeto_Integrador3.Properties.Resources.resources \
  -r:System.Core.dll \
  -r:System.Data.dll \
  -r:System.Data.DataSetExtensions.dll \
  -r:System.Design.dll \
  -r:System.Drawing.dll \
  -r:System.Configuration.dll \
  -r:System.Management.dll \
  -r:System.Net.Http.dll \
  -r:System.Web.dll \
  -r:System.Windows.Forms.dll \
  -r:System.Xml.dll \
  -r:System.Xml.Linq.dll \
  -r:Microsoft.CSharp.dll \
  -r:Microsoft.VisualBasic.dll \
  -r:DraftServer.dll \
  -r:packages/Guna.UI2.WinForms.2.0.4.7/lib/net48/Guna.UI2.dll \
  -r:packages/MyReaLTaiizor.1.1.6/lib/net462/MultifuncControl.dll \
  -r:packages/ReaLTaiizor.3.8.1.5/lib/net48/ReaLTaiizor.dll

cp DraftServer.dll bin/Debug/
cp packages/Guna.UI2.WinForms.2.0.4.7/lib/net48/Guna.UI2.dll bin/Debug/
cp packages/MyReaLTaiizor.1.1.6/lib/net462/MultifuncControl.dll bin/Debug/
cp packages/ReaLTaiizor.3.8.1.5/lib/net48/ReaLTaiizor.dll bin/Debug/

echo "Build concluído: bin/Debug/Projeto_Integrador3.exe"
```

### `run-linux.sh`

```bash
#!/usr/bin/env bash
set -euo pipefail

cd "$(dirname "$0")"
mono bin/Debug/Projeto_Integrador3.exe
```

Make them executable:

```bash
chmod +x build-linux.sh run-linux.sh
```

Then your real workflow becomes:

```bash
./build-linux.sh
./run-linux.sh
```

---

## What not to rely on

Do **not** rely on `xbuild Projeto_Integrador3.sln` as the main Linux workflow for this repo. In your own logs, `xbuild` on Fedora 42 warned that the project’s `TargetFrameworkVersion 'v4.8'` was unsupported by its toolset, and that path led to the `System.Object` / `CS0518` cascade.

---

## The gotchas to remember

* Fresh clone is okay; **absolute path does not matter**.
* What matters is:

  * run from the **repo root**
  * restore `packages/`
  * ensure `DraftServer.dll` exists in the repo root before compile
  * ensure `Tabuleiro.jpg` gets copied to `bin/Debug/`
  * generate `.resources`
  * compile with `mcs`
  * copy all runtime DLLs beside the `.exe` before running.  ([Mono Project][1])

One caveat: even with this setup, if `DraftServer.dll` itself depends on some Windows-only piece, you may still hit runtime issues later. But for the setup you already proved, this is the closest thing to a **repeatable Fedora recipe**.

I can turn this into a cleaner README section in Portuguese for your repo.

[1]: https://www.mono-project.com/docs/advanced/assemblies-and-the-gac/?utm_source=chatgpt.com "Assemblies and the GAC | Mono"
[2]: https://packages.fedoraproject.org/pkgs/mono/mono-devel/fedora-42.html?utm_source=chatgpt.com "mono-devel-6.12.0-19.fc42 - Fedora Packages"


---

# Compilar e rodar

Yeah — the most likely thing you’re missing is the **rebuild step**.

Right now your Linux workflow is **manual**: first `mcs` compiles the source into `bin/Debug/Projeto_Integrador3.exe`, then `mono` runs that `.exe`. Your own log shows those as two separate steps, so just saving a `.cs` file does **not** update the executable until you compile again.  Mono’s own docs also treat `mcs` as the explicit compiler you run on source files, not something that auto-rebuilds when you save. ([Mono Project][1])

So if you change:

* `XYZ` → `ABC` in `Form1.cs`
* save
* then run only `mono bin/Debug/Projeto_Integrador3.exe`

you are still running the **old exe** unless you reran `mcs`.

## What to do every time after editing code

If you changed only normal code files like:

* `Form1.cs`
* `Program.cs`
* `Form1.Designer.cs`

then do:

```bash
mcs -debug -target:winexe \
  -out:bin/Debug/Projeto_Integrador3.exe \
  Form1.cs Form1.Designer.cs Program.cs \
  Properties/AssemblyInfo.cs Properties/Resources.Designer.cs Properties/Settings.Designer.cs \
  -resource:obj/Debug/Projeto_Integrador3.Form1.resources \
  -resource:obj/Debug/Projeto_Integrador3.Properties.Resources.resources \
  -r:System.Core.dll \
  -r:System.Data.dll \
  -r:System.Data.DataSetExtensions.dll \
  -r:System.Design.dll \
  -r:System.Drawing.dll \
  -r:System.Configuration.dll \
  -r:System.Management.dll \
  -r:System.Net.Http.dll \
  -r:System.Web.dll \
  -r:System.Windows.Forms.dll \
  -r:System.Xml.dll \
  -r:System.Xml.Linq.dll \
  -r:Microsoft.CSharp.dll \
  -r:Microsoft.VisualBasic.dll \
  -r:DraftServer.dll \
  -r:packages/Guna.UI2.WinForms.2.0.4.7/lib/net48/Guna.UI2.dll \
  -r:packages/MyReaLTaiizor.1.1.6/lib/net462/MultifuncControl.dll \
  -r:packages/ReaLTaiizor.3.8.1.5/lib/net48/ReaLTaiizor.dll
```

Then:

```bash
mono bin/Debug/Projeto_Integrador3.exe
```

## When you must also rerun `resgen`

If you changed:

* `Properties/Resources.resx`
* `Form1.resx`
* images/icons/resource-backed strings

then **save is still not enough**. You must regenerate the `.resources` files first, then recompile.

That is explicitly called out in your generated `Resources.Designer.cs`: for `.resx` changes, edit the `.ResX` and **run ResGen again**, or rebuild in Visual Studio. 

So in that case:

```bash
resgen Form1.resx obj/Debug/Projeto_Integrador3.Form1.resources
resgen Properties/Resources.resx obj/Debug/Projeto_Integrador3.Properties.Resources.resources
```

and **then** rerun the `mcs` command.

## The 4 most common reasons you still see old text

### 1) You saved, but didn’t recompile

Most likely cause.

### 2) You edited the wrong clone/path

You mentioned you now have a fresh clone under a different path. This is a classic trap: edit one repo, run the `.exe` from another.

Check:

```bash
pwd
readlink -f Form1.cs
readlink -f bin/Debug/Projeto_Integrador3.exe
```

Both should be inside the **same clone**.

### 3) You changed the wrong file

For example:

* UI text may live in `Form1.Designer.cs`
* resource-backed content may live in `.resx`
* runtime messages may live in `Form1.cs`

Your current uploaded `Form1.cs` still contains `MessageBox.Show("Equipe: SeuNomeOuGrupo");`, so if that exact old text is what you keep seeing, there’s a good chance the file you’re actually compiling still has the old string. 

### 4) You’re running a stale exe

Force it by deleting the old binary first:

```bash
rm -f bin/Debug/Projeto_Integrador3.exe
```

Then rebuild and run again.

## Fast way to verify what’s happening

Run this from the repo root:

```bash
grep -R "ABC" -n .
stat bin/Debug/Projeto_Integrador3.exe
```

If `grep` does **not** find `ABC`, then you didn’t save where you think you saved.
If it finds `ABC` but the `.exe` timestamp did not change after rebuild, then your compile step didn’t actually run.
If both are correct and the UI still shows old text, then the text is probably coming from a **different file** such as `Form1.Designer.cs` or a `.resx`.

## The safest workflow

Use this order every single time:

```bash
# 1. save files

# 2. if you changed any .resx:
resgen Form1.resx obj/Debug/Projeto_Integrador3.Form1.resources
resgen Properties/Resources.resx obj/Debug/Projeto_Integrador3.Properties.Resources.resources

# 3. rebuild
mcs ...

# 4. rerun
mono bin/Debug/Projeto_Integrador3.exe
```

## Best debugging trick right now

Temporarily add a very obvious stamp in `Form1()` or `Program.Main()`:

```csharp
MessageBox.Show("BUILD TEST 123");
```

Your app starts with `Application.Run(new Form1());`, so that constructor path is definitely being hit on launch.  

If that popup does **not** appear after rebuild, then you are definitely either:

* compiling the wrong files,
* running the wrong exe,
* or skipping the rebuild.

The most likely missing step is simply: **save → rebuild → run**, not just **save → run**.

[1]: https://www.mono-project.com/community/help/?utm_source=chatgpt.com "Help | Mono"

----

# Apontar o MONO para o DLL e rodar

export MONO_PATH="$PWD:$PWD/bin/Debug:$PWD/packages/Guna.UI2.WinForms.2.0.4.7/lib/net48:$PWD/packages/MyReaLTaiizor.1.1.6/lib/net462:$PWD/packages/ReaLTaiizor.3.8.1.5/lib/net48"

mono bin/Debug/Projeto_Integrador3.exe
