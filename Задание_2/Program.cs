using System;

class Program {
    static void Main(string[] args) {
        double x1 = 3, y1 = 6, z1 = 8;
        double x2 = 2, y2 = 1, z2 = -7;
        double distance = Distance3D(x1, y1, z1, x2, y2, z2);
        Console.WriteLine("Distance between A and B: " + distance.ToString("F2"));

        x1 = 7; y1 = -5; z1 = 0;
        x2 = 1; y2 = -1; z2 = 9;
        distance = Distance3D(x1, y1, z1, x2, y2, z2);
        Console.WriteLine("Distance between A and B: " + distance.ToString("F2"));
    }

    static double Distance3D(double x1, double y1, double z1, double x2, double y2, double z2) {
        double dx = x2 - x1;
        double dy = y2 - y1;
        double dz = z2 - z1;
        return Math.Sqrt(dx * dx + dy * dy + dz * dz);
    }
}

