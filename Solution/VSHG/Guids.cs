using System;

namespace VSHG
{
    // How to: Obtain a PLK for a VSPackage
    // http://msdn.microsoft.com/en-us/vstudio/cc655795.aspx


    /*
    VisualHG
    Package Version 	1.0.0.0
    Package GUID 	F3DB741F-B40B-40be-A606-571A4BC653AB
    Product Name 	<none>
    Company Name 	VisualHG@live.de
    Visual Studio Version 	Visual Studio 2008
    Minimum Edition 	Professional
    Package Load Key (PLK) 	HPCED8Z3IRZQIRZ1D9IQRHJ9H0KCKMDIPTK0Z3QQJJDDIAKPAPM1PDMQMKC2JTQIICM3KECKQJPPK9HKHQQRD8DQP8JZAJIZJRM8ZMPCM8M0H1PJE2R9JQK0MERMJ3K2
    Description 	Mercurial source control integration
    */
    /*
    VisualHG
    Package Version 	1.0.0.1
    Package GUID 	F3DB741F-B40B-40be-A606-571A4BC653AB
    Product Name 	<none>
    Company Name 	VisualHG@live.de
    Visual Studio Version 	Visual Studio 2008
    Minimum Edition 	Professional
    Package Load Key (PLK) 	Z9IERHMDAERIDIP3CAHTJ2ZQQEZJEMAJD8R3IRA1DTD1M9DKPKEMQ9KTJQRIAPAPMZAMQJIAIZMPP9JIDRDMD2IPPMMTJ2RJAHJIJ9MJRMAPIEA2MAJ1PKZ1C2K8E3JD
    Description 	Mercurial source control integration
    */
    /*
    VisualHG
    Package Version 	1.0.0.3
    Package GUID 	DADADA00-348D-4EB9-95F2-DE3C44642044
    Product Name 	<none>
    Company Name 	VisualHG@live.de
    Visual Studio Version 	Visual Studio 2005
    Minimum Edition 	Standard
    Package Load Key (PLK) 		Q3KCEJI0DJC8A2ARAZQREIC2RDQPRPEIIZD2M1I8AMZQQ9H3IQPHKTAMIDP9H1MTC1J1RCJIAKZZHEZERMADPTJCRAD1A2KQECM3CHPAH8ETR2QPDEHQH8C8K8C2CRIK
    Description 	Mercurial source control integration

    public const string PackageGuid     = "DADADA00-348D-4EB9-95F2-DE3C44642044";
    public const string PackageVersion  = "1.0.0.3";
    public const string PakageName      = "VisualHG";
    public const string CompanyName     = "VisualHG@live.de";
    public const string MinEdition      = "Standard";
    Q3KCEJI0DJC8A2ARAZQREIC2RDQPRPEIIZD2M1I8AMZQQ9H3IQPHKTAMIDP9H1MTC1J1RCJIAKZZHEZERMADPTJCRAD1A2KQECM3CHPAH8ETR2QPDEHQH8C8K8C2CRIK

     * 
    Ver 1.1.0
    public const string PackageGuid     = "DADADA00-19aa-4a19-a6c4-25f8d4019b4d";
    public const string PackageVersion  = "1.0.0.4";
    public const string PakageName      = "VisualHG";
    public const string CompanyName     = "VisualHG@live.de";
    public const string MinEdition      = "Standard";
  AMRKJQE1ECKIDED1APDZMIE3ZPDACCPCAQA3M3KRC3KKI0M8PHQKQTD0JZJ2A2MDJ2C2H0AZA9DPC0R2PECECIJ9P1IRJPZ9I0EKJDR8QAJ1QAEHMAD2EAMMR2KEIIHD

    * 
    Ver 1.1.1
    public const string PackageGuid     = "DADADA00-caaf-423f-b21d-2df00fa25ca3";
    public const string PackageVersion  = "1.0.0.5";
    public const string PakageName      = "VisualHG";
    public const string CompanyName     = "VisualHG@live.de";
    public const string MinEdition      = "Standard";
    EHDKIZK1PCQCH8R2IMDHAKQQATQ3RZMEC0D1IZJDEJI2IMQCQIDRC1Z3E8CRIJPPKJIDHPMCCJQ9CQE2ADCAJQDPEQJ1D9KHZZCKHZRMPRE9JJJZP2Z1QAETHZI3K2KE

    * 
    Ver 1.1.4
    public const string PackageGuid     = "DADADA00-dfd3-4e42-a61c-499121e136f3";
    public const string PackageVersion  = "1.0.0.6";
    public const string PakageName      = "VisualHG";
    public const string CompanyName     = "VisualHG@live.de";
    public const string MinEdition      = "Standard";
    ZPHPJZE3Z1PRAIJ8M2MKE3PDEDPQI1DRCQM1I8DJD1E0MKQ0I2MAC8PZKHH9JRMIK9QHC9ZZP8I8RMCEIQC3QPA1P2Z1M0ZHQZI8M2QZRAPZJCPCD0KAJ0IAZIDIH3Q1

  */


    /*
     * 
    Ver 1.2.0
    Internal name: vshg v.1.2.0
    public const string PackageGuid     = "DADADA00-dfd3-4e42-a61c-499121e136f3";
    public const string PackageVersion  = "1.2.0.1";
    public const string PakageName      = "VSHG";
    public const string CompanyName     = "d-popov@abv.bg";
    public const string MinEdition      = "Standard";
 
     */


    public static class PLK
    {
        public const string PackageGuid = "DADADA00-dfd3-4e42-a61c-499121e136f3";
        public const string PackageVersion  = "1.2.0.1";
        public const string PakageName      = "VSHG";
        public const string CompanyName     = "d-popov@abv.bg";
        public const string MinEdition      = "Standard";
    };
    
    /// <summary>
	/// This class is used only to expose the list of Guids used by this package.
	/// This list of guids must match the set of Guids used inside the VSCT file.
	/// </summary>
    public static class GuidList
    {
    	// Now define the list of guids as public static members.
        public const string HGPendingChangesToolWindowGuid = "DADADA00-d3b4-4d5c-a138-a87ca494f6c2";
        public const string ProviderOptionsPageGuid = "DADADA00-09a5-4795-a3ca-c3b49448184d";
   
        // Unique ID of the source control provider; this is also used as the command UI context to show/hide the pacakge UI
        public const string ProviderGuid = "DADADA00-63c7-4363-b107-ad5d9d915d45";
        public static readonly Guid guidSccProvider = new Guid(ProviderGuid);
        // The guid of the source control provider service (implementing IVsSccProvider interface)
        public const string ProviderServiceGuid = "DADADA00-d8ac-4ba7-8b05-5166c8f08ef5";
        public static readonly Guid guidSccProviderService = new Guid(ProviderServiceGuid);
        // The guid of the source control provider package (implementing IVsPackage interface)
        public static readonly Guid guidSccProviderPkg = new Guid(PLK.PackageGuid);
        // Other guids for menus and commands
        public static readonly Guid guidSccProviderCmdSet = new Guid("{DADADA00-1fd3-4e26-9c1d-c9cb723cea0e}");
    };

}
