// Today was super insightful and taught me the core and essential basics of decimal variables. It was actually so confusing and took me like 15 minutes to understand but after comparing the code with what they did, it got easier and easier.

int currentAssignments = 5;

int neil1 = 93;
int neil2 = 87;
int neil3 = 98;
int neil4 = 95;
int neil5 = 100;

int josh1 = 80;
int josh2 = 83;
int josh3 = 82;
int josh4 = 88;
int josh5 = 85;

int abdullah1 = 84;
int abdullah2 = 96;
int abdullah3 = 73;
int abdullah4 = 85;
int abdullah5 = 79;

int aarya1 = 90;
int aarya2 = 92;
int aarya3 = 98;
int aarya4 = 100;
int aarya5 = 97;

int neilSum = neil1 + neil2 + neil3 + neil4 + neil5;
int joshSum = josh1 + josh2 + josh3 + josh4 + josh5;
int abdullahSum = abdullah1 + abdullah2 + abdullah3 + abdullah4 + abdullah5;
int aaryaSum = aarya1 + aarya2 + aarya3 + aarya4 + aarya5;

decimal neilScore = (decimal) neilSum / currentAssignments;
decimal joshScore = (decimal) joshSum / currentAssignments;
decimal abdullahScore = (decimal) abdullahSum / currentAssignments;
decimal aaryaScore = (decimal) aaryaSum / currentAssignments;

Console.WriteLine("neil: " + neilScore + " A");
Console.WriteLine("josh: " + joshScore + " B");
Console.WriteLine("abdullah: " + abdullahScore + " B");
Console.WriteLine("aarya: " + aaryaScore + " A");
