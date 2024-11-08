import 'dart:io';

List<String> GetLanguage() {
  switch (Platform.localeName) {
    case 'zh-CN':
      return ['清除长期未使用的 Nuget 包', '清除中...', '清除结束，这个窗口可以关闭了'];
    default:
      return [
        'Remove Long Unused Nuget Packages',
        'Removing...',
        'Remove is complete, the window can be closed.'
      ];
  }
}
