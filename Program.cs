// See https://aka.ms/new-console-template for more information
double gewichtOpAarde = 155.0;
string[] planeet = { "Mercurius", "Venus", "Aarde", "Mars", "Jupiter", "Saturnus", "Uranus", "Neptunus", "Pluto" };
double[] gewicht = new double[9];
gewicht[0]= gewichtOpAarde * 0.38;
gewicht[1]= gewichtOpAarde * 0.91;
gewicht[2]= gewichtOpAarde * 1.00;
gewicht[3]= gewichtOpAarde * 0.38;
gewicht[4]= gewichtOpAarde * 2.34;
gewicht[5]= gewichtOpAarde * 1.06;
gewicht[6]= gewichtOpAarde * 0.92;
gewicht[7]= gewichtOpAarde * 1.19;
gewicht[8]= gewichtOpAarde * 0.06;

for (int i = 0; i < gewicht.Length; i++)
{
    Console.WriteLine($"Je weegt op {planeet[i]} {gewicht[i]} kg.");
}
