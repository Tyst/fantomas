﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Fantomas")>]
[<assembly: AssemblyProductAttribute("Fantomas")>]
[<assembly: AssemblyDescriptionAttribute("Source code formatter for F#")>]
[<assembly: AssemblyVersionAttribute("2.3.0")>]
[<assembly: AssemblyFileVersionAttribute("2.3.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "2.3.0"
