using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.Media.Imaging;
using Avalonia.Platform.Storage;
using PZ.RxAvalonia.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Security.Cryptography;
using System.Text;

namespace PZ.RxAvalonia.Demo;

internal class RxEventView : ComponentBase
{
    protected override Control Build()
    {
        return new StackPanel()
            .Orientation(Orientation.Vertical)
            .Children(
                new StackPanel()
                    .Orientation(Orientation.Horizontal)
                    .Margin(10)
                    .Spacing(10)
                    .Children(
                        new TextBlock().Text("File"),
                        new TextBox().Text(SelectedFile.AsObservable()).Width(400).IsReadOnly(true),
                        new Button().Content("Select File").RxClick(OnSelectFile),
                        new Button().Content("OpenAsImage").RxClick(OnOpenImage)
                    ),
                new StackPanel()
                    .Orientation(Orientation.Horizontal)
                    .Margin(10)
                    .Spacing(10)
                    .Children(
                        new TextBlock().Text("Text"),
                        new TextBox().Text(Text).Width(300),
                        new Button().Content("To MD5").RxClick(OnToMd5),
                        new TextBlock().Text("Text Md5"),
                        new TextBox().Text(Md5Text).Width(300).IsReadOnly(true)
                    ),
                    new TextBlock().Text("Image:"),
                    new Image().Height(250).Source(ImageSource)
            );
    }

    protected override void OnCreated()
    {
        base.OnCreated();

        OnOpenImage.WithLatestFrom(SelectedFile)
            .Where(t => !string.IsNullOrEmpty(t.Second))
            .Select(t => LoadImage(t.Second))
            .Subscribe(ImageSource);

        OnSelectFile.Select(_ => SelectFile())
            .Concat()
            .Subscribe(SelectedFile);

        OnToMd5.WithLatestFrom(Text)
            .Select(t => t.Second)
            .WhereNotEmpty(true)
            .Select(ToMd5)
            .Subscribe(Md5Text);
    }

    private readonly BehaviorSubject<string> SelectedFile = new(string.Empty);
    private readonly BehaviorSubject<string> Text = new(string.Empty);
    private readonly BehaviorSubject<string> Md5Text = new(string.Empty);
    private readonly Subject<Bitmap?> ImageSource = new();

    private readonly Subject<RoutedEventArgs> OnOpenImage = new();
    private readonly Subject<RoutedEventArgs> OnSelectFile = new();
    private readonly Subject<RoutedEventArgs> OnToMd5 = new();

    private async Task<string> SelectFile()
    {
        TopLevel topLevel = TopLevel.GetTopLevel(this)!;
        var files = await topLevel.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions
        {
            Title = "Open File",
            AllowMultiple = false
        });

        if (files.Count >= 1)
        {
            return files[0].Path.LocalPath;
        }

        return "";
    }
    private string ToMd5(string text)
    {
        var bytes = Encoding.UTF8.GetBytes(text);
        var hashBytes = MD5.Create().ComputeHash(bytes);
        return Convert.ToHexString(hashBytes);
    }
    private Bitmap? LoadImage(string file)
    {
        FileInfo fileInfo = new FileInfo(file);
        bool isImage = fileInfo.Extension switch
        {
            ".jpeg" or ".jpg" or ".png" or ".gif" => true,
            _ => false
        };

        if (File.Exists(file) && isImage)
        {
            try
            {
                using var f = fileInfo.OpenRead();
                var bytes = new byte[f.Length];
                f.ReadExactly(bytes);
                using var memStream = new MemoryStream(bytes);
                memStream.Seek(0, SeekOrigin.Begin);

                return new Bitmap(memStream);
            }
            catch
            {
                return null;
            }
        }

        return null;
    }
}
