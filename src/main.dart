import 'dart:io';
import 'language.dart';

void main() {
  // Load language
  var lang = GetLanguage();
  print(lang[0] + "\n");
  print(lang[1] + "\n");

  // var path;
  // if (Platform.isWindows) path = Platform.environment['userprofile'].toString() + "/.nuget/packages";
  // else if (Platform.isLinux) path = null;
  // else if (Platform.isMacOS) path = null;

  // Get path
  var path = Directory(
      Platform.environment['userprofile'].toString() + '/.nuget/packages');

  // Get a timestamp from 3 months ago
  var timestamp =
      DateTime.now().add(new Duration(days: -90)).millisecondsSinceEpoch;

  // Remove start
  if (path.existsSync()) {
    var list = path.listSync();
    for (var li in list) {
      if (li.statSync().modified.millisecondsSinceEpoch < timestamp)
        li.deleteSync(recursive: true);
    }
  }

  print(lang[2]);
  stdin.readLineSync();
}
