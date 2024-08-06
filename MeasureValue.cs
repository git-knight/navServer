using System.Runtime.InteropServices;

// In SDK-style projects such as this one, several assembly attributes that were historically
// defined in this file are now automatically added during build and populated with
// values defined in project properties. For details of which attributes are included
// and how to customise this process see: https://aka.ms/assembly-info-properties


// Setting ComVisible to false makes the types in this assembly not visible to COM
// components.  If you need to access a type in this assembly from COM, set the ComVisible
// attribute to true on that type.

//[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM.

//[assembly: Guid("d7f5c449-3160-487d-9481-9fa4454ad9f2")]

public class MeasureValue
{
    public int Id { get; set; }
    public long Time { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public double Pressure { get; set; }
    public double Azimuth { get; set; }
    public double AtAccuracym { get; set; }

    public override string ToString()
    {
        return DateTime.FromFileTime(Time).ToString("f") + $"{Latitude}:{Longitude}";
    }
}