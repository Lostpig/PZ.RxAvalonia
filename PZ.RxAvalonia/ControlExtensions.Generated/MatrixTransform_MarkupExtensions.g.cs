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
public static partial class MatrixTransform_MarkupExtensions
{
//================= Properties ======================//
 // Matrix

/*ValueSetterGenerator*/
public static Avalonia.Media.MatrixTransform Matrix(this Avalonia.Media.MatrixTransform control, Avalonia.Matrix value)  
{
    control.Matrix = value!;
    return control;
}

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.MatrixTransform Matrix(this Avalonia.Media.MatrixTransform control, System.Double scaleX = default!, System.Double skewY = default!, System.Double skewX = default!, System.Double scaleY = default!, System.Double offsetX = default!, System.Double offsetY = default!)  
{
    control.Matrix = new Avalonia.Matrix(scaleX, skewY, skewX, scaleY, offsetX, offsetY);
    return control;
}
public static Avalonia.Media.MatrixTransform Matrix(this Avalonia.Media.MatrixTransform control, System.Double scaleX = default!, System.Double skewY = default!, System.Double perspX = default!, System.Double skewX = default!, System.Double scaleY = default!, System.Double perspY = default!, System.Double offsetX = default!, System.Double offsetY = default!, System.Double perspZ = default!)  
{
    control.Matrix = new Avalonia.Matrix(scaleX, skewY, perspX, skewX, scaleY, perspY, offsetX, offsetY, perspZ);
    return control;
}

/*SetterFromFuncGenerator*/
public static Avalonia.Media.MatrixTransform Matrix(this Avalonia.Media.MatrixTransform control, Func<Avalonia.Matrix> func)  
   => control._set(Avalonia.Media.MatrixTransform.MatrixProperty!, func);

/*SetterFromObservableGenerator*/
public static Avalonia.Media.MatrixTransform Matrix(this Avalonia.Media.MatrixTransform control, IObservable<Avalonia.Matrix> obs)  
   => control._set(Avalonia.Media.MatrixTransform.MatrixProperty!, obs);

/*SetterFromSubjectGenerator*/
public static Avalonia.Media.MatrixTransform Matrix(this Avalonia.Media.MatrixTransform control, ISubject<Avalonia.Matrix> subject)  
   => control._set(Avalonia.Media.MatrixTransform.MatrixProperty!, subject);



}
