#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Reactive.Subjects;
using System.Runtime.CompilerServices;

namespace PZ.RxAvalonia;
[global::System.CodeDom.Compiler.GeneratedCode("PZ.AvaloniaExtensionGenerator", "1.0.0.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class ResourceProvider_MarkupExtensions
{
//================= Events ======================//
 // OwnerChanged

/*ActionToEventGenerator*/
public static T OnOwnerChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.ResourceProvider  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.OwnerChanged += h);



}
