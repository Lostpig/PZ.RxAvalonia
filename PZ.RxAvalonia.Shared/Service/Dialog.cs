using Avalonia.Controls;
using PZ.RxAvalonia.Shared.Dialog;
using MIcon = Material.Icons.MaterialIconKind;
using Uc = Ursa.Controls;

namespace PZ.RxAvalonia.Shared.Service;

public class DialogService(Window mainWindow)
{
    public Task<DialogReturn<int>> Confirm(string message, string? title = null)
    {
        title ??= TranslateService.GetBaseField("Confirm");
        var opt = ConfirmDialog(title, message);
        return ShowDialog(opt);
    }
    public Task<DialogReturn<int>> Alert(string message, string? title = null)
    {
        title ??= TranslateService.GetBaseField("Alert");
        var opt = AlertDialog(title, message);
        return ShowDialog(opt);
    }
    public async Task<DialogReturn<T>> ShowDialog<T>(DialogContentBase<T> content)
    {
        var semiOpts = new Uc.OverlayDialogOptions()
        {
            FullScreen = false,
            HorizontalAnchor = Uc.HorizontalPosition.Center,
            VerticalAnchor = Uc.VerticalPosition.Center,
            Mode = Uc.DialogMode.None,
            CanLightDismiss = false,
            CanDragMove = true,
            IsCloseButtonVisible = false,
            CanResize = false
        };

        var dialog = new Dialog<T>(content, mainWindow);
        var result = await Uc.OverlayDialog.ShowCustomAsync<DialogReturn<T>>(dialog, dialog, options: semiOpts);

        return result!;
    }

    public static MessageBox ConfirmDialog(string title, string message)
    {
        return new MessageBox(message)
        {
            Title = title,
            Icon = MIcon.Info,
            BoxButtons = [
                new(TranslateService.GetBaseField("OK"), Uc.DialogResult.OK),
                new(TranslateService.GetBaseField("Cancel"), Uc.DialogResult.Cancel) { Styles = ["Tertiary"] },
            ]
        };
    }
    public static MessageBox AlertDialog(string title, string message)
    {
        return new MessageBox(message)
        {
            Title = title,
            Icon = MIcon.Alert,
        };
    }
    public static MessageBox DeleteConfirmDialog(string? title = null, string? message = null)
    {
        title ??= TranslateService.GetBaseField("Delete");
        message ??= TranslateService.GetBaseField("MSG_SureToDelete");

        return new MessageBox(message)
        {
            Title = title,
            Icon = MIcon.Alert,
            BoxButtons = [
                new(TranslateService.GetBaseField("Delete"), Uc.DialogResult.OK){ Styles = ["Danger"] },
                new(TranslateService.GetBaseField("Cancel"), Uc.DialogResult.Cancel) { Styles = ["Tertiary"] },
            ]
        };
    }

    public static bool IsSureResult(Uc.DialogResult res)
    {
        return res == Uc.DialogResult.OK || res == Uc.DialogResult.Yes;
    }
}


