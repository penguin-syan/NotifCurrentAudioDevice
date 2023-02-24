using Microsoft.Toolkit.Uwp.Notifications;
using NAudio.CoreAudioApi;

// アプリ通知に表示するため、オーディオ出力先を取得
var enumerator = new MMDeviceEnumerator();
var result = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Console);

// 連続切り替え時にアプリ通知を更新するために通知履歴を削除
ToastNotificationManagerCompat.History.Clear();

// 変更後のオーディオ出力先をアプリ通知
new ToastContentBuilder()
    .AddArgument("action", "viewConversation")
    .AddArgument("conversationId", 9813)
    .AddText("Output audio device")
    .AddText(String.Format("{0}", result))
    .Show();
