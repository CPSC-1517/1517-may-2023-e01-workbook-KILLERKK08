using OOPsReview;
Residence myHome = new Residence(123, "Maple St.", "Edmonton", "AB", "T6Y7U8");
Console.WriteLine(myHome.ToString());


myHome = new Residence(321, "Maple St.", "Edmonton", "AB", "T6Y7U8");
Console.WriteLine(myHome.ToString());

bool flag = false;
if (myHome.Province.ToLower() == "ab")
{
    flag = true;
}
if (myHome.Province.ToLower() == "bc")
{
    flag = true;
}
if (myHome.Province.ToLower() == "sk")
{
    flag = true;
}
if (myHome.Province.ToLower() == "mn")
{
    flag = true;
}

switch (myHome.Province.ToLower())
{
    case "ab":
    case "sk":
    case "bc":
    case "mn":
        {
            flag = true;
            break;
        }
        default:
        {
            flag = false;
            break;
        }

}