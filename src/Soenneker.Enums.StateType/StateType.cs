using Soenneker.SmartEnum.AbbreviatedDescriptive;

namespace Soenneker.Enums.StateType;

/// <summary>
/// An enumeration for US States
/// </summary>
public class StateType : AbbreviatedDescriptiveSmartEnum<StateType>
{
    /// <summary>
    /// The alabama.
    /// </summary>
    public static readonly StateType Alabama = new(nameof(Alabama), 1, "AL");
    /// <summary>
    /// The alaska.
    /// </summary>
    public static readonly StateType Alaska = new(nameof(Alaska), 2, "AK");
    /// <summary>
    /// The arizona.
    /// </summary>
    public static readonly StateType Arizona = new(nameof(Arizona), 3, "AZ");
    /// <summary>
    /// The arkansas.
    /// </summary>
    public static readonly StateType Arkansas = new(nameof(Arkansas), 4, "AR");
    /// <summary>
    /// The california.
    /// </summary>
    public static readonly StateType California = new(nameof(California), 5, "CA");
    /// <summary>
    /// The colorado.
    /// </summary>
    public static readonly StateType Colorado = new(nameof(Colorado), 6, "CO");
    /// <summary>
    /// The connecticut.
    /// </summary>
    public static readonly StateType Connecticut = new(nameof(Connecticut), 7, "CT");
    /// <summary>
    /// The delaware.
    /// </summary>
    public static readonly StateType Delaware = new(nameof(Delaware), 8, "DE");
    /// <summary>
    /// The district of columbia.
    /// </summary>
    public static readonly StateType DistrictOfColumbia = new(nameof(DistrictOfColumbia), 8, "DC", "District of Columbia");
    /// <summary>
    /// The florida.
    /// </summary>
    public static readonly StateType Florida = new(nameof(Florida), 9, "FL");
    /// <summary>
    /// The georgia.
    /// </summary>
    public static readonly StateType Georgia = new(nameof(Georgia), 10, "GA");
    /// <summary>
    /// The hawaii.
    /// </summary>
    public static readonly StateType Hawaii = new(nameof(Hawaii), 11, "HI");
    /// <summary>
    /// The idaho.
    /// </summary>
    public static readonly StateType Idaho = new(nameof(Idaho), 12, "ID");
    /// <summary>
    /// The illinois.
    /// </summary>
    public static readonly StateType Illinois = new(nameof(Illinois), 13, "IL");
    /// <summary>
    /// The indiana.
    /// </summary>
    public static readonly StateType Indiana = new(nameof(Indiana), 14, "IN");
    /// <summary>
    /// The iowa.
    /// </summary>
    public static readonly StateType Iowa = new(nameof(Iowa), 15, "IA");
    /// <summary>
    /// The kansas.
    /// </summary>
    public static readonly StateType Kansas = new(nameof(Kansas), 16, "KS");
    /// <summary>
    /// The kentucky.
    /// </summary>
    public static readonly StateType Kentucky = new(nameof(Kentucky), 17, "KY");
    /// <summary>
    /// The louisiana.
    /// </summary>
    public static readonly StateType Louisiana = new(nameof(Louisiana), 18, "LA");
    /// <summary>
    /// The maine.
    /// </summary>
    public static readonly StateType Maine = new(nameof(Maine), 19, "ME");
    /// <summary>
    /// The maryland.
    /// </summary>
    public static readonly StateType Maryland = new(nameof(Maryland), 20, "MD");
    /// <summary>
    /// The massachusetts.
    /// </summary>
    public static readonly StateType Massachusetts = new(nameof(Massachusetts), 21, "MA");
    /// <summary>
    /// The michigan.
    /// </summary>
    public static readonly StateType Michigan = new(nameof(Michigan), 22, "MI");
    /// <summary>
    /// The minnesota.
    /// </summary>
    public static readonly StateType Minnesota = new(nameof(Minnesota), 23, "MN");
    /// <summary>
    /// The missouri.
    /// </summary>
    public static readonly StateType Missouri = new(nameof(Missouri), 24, "MO");
    /// <summary>
    /// The mississippi.
    /// </summary>
    public static readonly StateType Mississippi = new(nameof(Mississippi), 25, "MS");
    /// <summary>
    /// The montana.
    /// </summary>
    public static readonly StateType Montana = new(nameof(Montana), 26, "MT");
    /// <summary>
    /// The nebraska.
    /// </summary>
    public static readonly StateType Nebraska = new(nameof(Nebraska), 27, "NE");
    /// <summary>
    /// The nevada.
    /// </summary>
    public static readonly StateType Nevada = new(nameof(Nevada), 28, "NV");
    /// <summary>
    /// The new hampshire.
    /// </summary>
    public static readonly StateType NewHampshire = new(nameof(NewHampshire), 29, "NH", "New Hampshire");
    /// <summary>
    /// The new jersey.
    /// </summary>
    public static readonly StateType NewJersey = new(nameof(NewJersey), 30, "NJ", "New Jersey");
    /// <summary>
    /// The new mexico.
    /// </summary>
    public static readonly StateType NewMexico = new(nameof(NewMexico), 31, "NM", "New Mexico");
    /// <summary>
    /// The new york.
    /// </summary>
    public static readonly StateType NewYork = new(nameof(NewYork), 32, "NY", "New York");
    /// <summary>
    /// The north carolina.
    /// </summary>
    public static readonly StateType NorthCarolina = new(nameof(NorthCarolina), 33, "NC", "North Carolina");
    /// <summary>
    /// The north dakota.
    /// </summary>
    public static readonly StateType NorthDakota = new(nameof(NorthDakota), 34, "ND", "North Dakota");
    /// <summary>
    /// The ohio.
    /// </summary>
    public static readonly StateType Ohio = new(nameof(Ohio), 35, "OH");
    /// <summary>
    /// The oklahoma.
    /// </summary>
    public static readonly StateType Oklahoma = new(nameof(Oklahoma), 36, "OK");
    /// <summary>
    /// The oregon.
    /// </summary>
    public static readonly StateType Oregon = new(nameof(Oregon), 37, "OR");
    /// <summary>
    /// The pennsylvania.
    /// </summary>
    public static readonly StateType Pennsylvania = new(nameof(Pennsylvania), 38, "PA");
    /// <summary>
    /// The puerto rico.
    /// </summary>
    public static readonly StateType PuertoRico = new(nameof(PuertoRico), 39, "PR", "Puerto Rico");
    /// <summary>
    /// The rhode island.
    /// </summary>
    public static readonly StateType RhodeIsland = new(nameof(RhodeIsland), 40, "RI", "Rhode Island");
    /// <summary>
    /// The south carolina.
    /// </summary>
    public static readonly StateType SouthCarolina = new(nameof(SouthCarolina), 41, "SC", "South Carolina");
    /// <summary>
    /// The south dakota.
    /// </summary>
    public static readonly StateType SouthDakota = new(nameof(SouthDakota), 42, "SD", "South Dakota");
    /// <summary>
    /// The tennessee.
    /// </summary>
    public static readonly StateType Tennessee = new(nameof(Tennessee), 43, "TN");
    /// <summary>
    /// The texas.
    /// </summary>
    public static readonly StateType Texas = new(nameof(Texas), 44, "TX");
    /// <summary>
    /// The utah.
    /// </summary>
    public static readonly StateType Utah = new(nameof(Utah), 45, "UT");
    /// <summary>
    /// The vermont.
    /// </summary>
    public static readonly StateType Vermont = new(nameof(Vermont), 46, "VT");
    /// <summary>
    /// The virginia.
    /// </summary>
    public static readonly StateType Virginia = new(nameof(Virginia), 47, "VA");
    /// <summary>
    /// The washington.
    /// </summary>
    public static readonly StateType Washington = new(nameof(Washington), 48, "WA");
    /// <summary>
    /// The west virginia.
    /// </summary>
    public static readonly StateType WestVirginia = new(nameof(WestVirginia), 49, "WV", "West Virginia");
    /// <summary>
    /// The wisconsin.
    /// </summary>
    public static readonly StateType Wisconsin = new(nameof(Wisconsin), 50, "WI");
    /// <summary>
    /// The wyoming.
    /// </summary>
    public static readonly StateType Wyoming = new(nameof(Wyoming), 51, "WY");

    public StateType(string name, int value, string abbreviation, string? description = null) : base(name, value, abbreviation, description, true)
    {
    }
}
