using System;

namespace neract_back.Pocos 
{
  static class C 
  {
    /// Set up the constants for the versioned webservices path.
    public static readonly string WsApiPath = "api";
    public static readonly string WsApiVer = "v1";
    public static readonly string WsPath = String.Format("{0}/{1}", WsApiPath, WsApiVer);

    /// Set up constants for each route.
    public static readonly string WsArticleEndpoint = "articles";

    /// Set up the default constants. They are the "Bad" auth values.
    public static readonly string InactiveToken = "######N-ACTIVE##########";
    public static readonly DateTime InactiveTimestamp = new DateTime(1980, 04, 11, 0, 0, 0);
    public static readonly string DefaultDisplayName = "Famous Mortimer";
    public static readonly string DefaultUsername = "foo";
    public static readonly string DefaultPassword = "bar";
    public static readonly string FamousMortimer = "FamousMortimer";
    public static readonly string LoremIpsumShort = "Lorem Ipsum";
    public static readonly string LoremIpsumLong = "Lorem Ipsum Cateca Cechi Ovlum Ferelli. Lorem Ipsum Cateca Cechi Ovlum Ferelli. Lorem Ipsum Cateca Cechi Ovlum Ferelli. Lorem Ipsum Cateca Cechi Ovlum Ferelli.";
  }
}