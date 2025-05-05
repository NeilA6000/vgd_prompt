
// Today, I learned that a lot of different components can affect what shows up in the console greatly, and how math can affect variables, not just in the console but in general.

int currentAssignments = 5;

int kairo1 = 93;
int kairo2 = 87;
int kairo3 = 98;
int kairo4 = 95;
int kairo5 = 100;

int neil1 = 80;
int neil2 = 83;
int neil3 = 82;
int neil4 = 88;
int neil5 = 85;

int caius1 = 84;
int caius2 = 96;
int caius3 = 73;
int caius4 = 85;
int caius5 = 79;

int josh1 = 90;
int josh2 = 92;
int josh3 = 98;
int josh4 = 100;
int josh5 = 97;

int kairoSum = kairo1 + kairo2 + kairo3 + kairo4 + kairo5;
int neilSum = neil1 + neil2 + neil3 + neil4 + neil5;
int caiusSum = caius1 + caius2 + caius3 + caius4 + caius5;
int joshSum = josh1 + josh2 + josh3 + josh4 + josh5;

decimal kairoScore = (decimal) kairoSum / currentAssignments;
decimal neilScore = (decimal) neilSum / currentAssignments;
decimal caiusScore = (decimal) caiusSum / currentAssignments;
decimal joshScore = (decimal) joshSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("kairo:\t\t" + kairoScore + "\tA");
Console.WriteLine("neil:\t" + neilScore + "\tB");
Console.WriteLine("caius:\t" + caiusScore + "\tB");
Console.WriteLine("josh:\t\t" + joshScore + "\tA");
