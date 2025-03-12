// Today, I learned that different escape sequences can actually do a lot of interesting things, such as generate russian characters and more. I feel this will be interesting when creating html text in websites.
string projectName = "FBI";
string englishversion = $@"c:\Repository\{projectName}\data";
Console.WriteLine($"View English output:{englishversion}");
string russianone = $@"c:\Repository\{projectName}\data";
string russianversion = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.WriteLine($"{russianversion}:{russianone}"); 
