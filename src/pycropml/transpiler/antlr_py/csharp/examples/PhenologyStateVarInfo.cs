//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

/// 
/// This class was created from file C:\Users\mancealo\Documents\GitSiriusCode\SiriusQuality-BioMa-Phenology-Component\SiriusQuality-PhenologyComponent\XML\SiriusQualityPhenology_PhenologyState.xml
/// The tool used was: DCC - Domain Class Coder, http://components.biomamodelling.org/, DCC
/// 
/// Loic Manceau
/// loic.manceau@inra.fr
/// INRA
/// 
/// 
/// 7/24/2018 10:51:23 AM
/// 
namespace SiriusQualityPhenology
{
    using System;
    using CRA.ModelLayer.Core;
    
    
    /// <summary>PhenologyStateVarInfoClasses contain the attributes for each variable in the domain class RainData. Attributes are valorized via the static constructor. The data-type VarInfo causes  a dependency to the assembly CRA.Core.Preconditions.dll</summary>
    public class PhenologyStateVarInfo : IVarInfoClass
    {
        
        static VarInfo _currentdate = new VarInfo();
        
        static VarInfo _cumulTT = new VarInfo();
        
        static VarInfo _DayLength = new VarInfo();
        
        static VarInfo _DeltaTT = new VarInfo();
        
        static VarInfo _GrainCumulTT = new VarInfo();
        
        static VarInfo _GAI = new VarInfo();
        
        static VarInfo _IsLatestLeafInternodeLengthPotPositive = new VarInfo();
        
        static VarInfo _Calendar = new VarInfo();
        
        static VarInfo _LeafNumber = new VarInfo();
        
        static VarInfo _FinalLeafNumber = new VarInfo();
        
        static VarInfo _phase_ = new VarInfo();
        
        static VarInfo _Phyllochron = new VarInfo();
        
        static VarInfo _Vernaprog = new VarInfo();
        
        static VarInfo _HasFlagLeafLiguleAppeared = new VarInfo();
        
        static VarInfo _MinFinalNumber = new VarInfo();
        
        static VarInfo _hasLastPrimordiumAppeared = new VarInfo();
        
        static VarInfo _isMomentRegistredZC_39 = new VarInfo();
        
        static VarInfo _cumulTTFromZC_39 = new VarInfo();
        
        static VarInfo _cumulTTFromZC_91 = new VarInfo();
        
        static VarInfo _cumulTTFromZC_65 = new VarInfo();
        
        static VarInfo _currentZadokStage = new VarInfo();
        
        static VarInfo _hasZadokStageChanged = new VarInfo();
        
        static VarInfo _tilleringProfile = new VarInfo();
        
        static VarInfo _leafTillerNumberArray = new VarInfo();
        
        static VarInfo _CanopyShootNumber = new VarInfo();
        
        static VarInfo _AverageShootNumberPerPlant = new VarInfo();
        
        static VarInfo _TillerNumber = new VarInfo();
        
        static VarInfo _PTQ = new VarInfo();
        
        static VarInfo _Fixphyll = new VarInfo();
        
        static VarInfo _GAImean = new VarInfo();
        
        static VarInfo _ListGAITTWindowForPTQ = new VarInfo();
        
        static VarInfo _PAR = new VarInfo();
        
        static VarInfo _ListPARTTWindowForPTQ = new VarInfo();
        
        static VarInfo _ListTTShootTTWindowForPTQ = new VarInfo();
        
        static VarInfo _pastGAI = new VarInfo();
        
        /// <summary>Constructor</summary>
        static PhenologyStateVarInfo()
        {
            PhenologyStateVarInfo.DescribeVariables();
        }
              /// <summary>Domain Class description</summary>
        public virtual  string Description
        {
            get
            {
                return "Domain class for the phenology component of Sirius Quality";
            }
        }
        
        /// <summary>Reference to the ontology</summary>
        public  string URL
        {
            get
            {
                return "http://";
            }
        }
        
        /// <summary>Value domain class of reference</summary>
        public  string DomainClassOfReference
        {
            get
            {
                return "PhenologyState";
            }
        }
        
        /// <summary>current date</summary>
        public static  VarInfo currentdate
        {
            get
            {
                return  _currentdate;
            }
        }
        
        /// <summary>array of the different cumulTT to be saved in the calendar. The first element is the one used to advance the phenology</summary>
        public static  VarInfo cumulTT
        {
            get
            {
                return  _cumulTT;
            }
        }
        
        /// <summary>length of the day</summary>
        public static  VarInfo DayLength
        {
            get
            {
                return  _DayLength;
            }
        }
        
        /// <summary>daily delta TT . It is the same kind of TT as cumulTT[0]</summary>
        public static  VarInfo DeltaTT
        {
            get
            {
                return  _DeltaTT;
            }
        }
        
        /// <summary>cumulTT used for the grain developpment</summary>
        public static  VarInfo GrainCumulTT
        {
            get
            {
                return  _GrainCumulTT;
            }
        }
        
        /// <summary>green area index</summary>
        public static  VarInfo GAI
        {
            get
            {
                return  _GAI;
            }
        }
        
        /// <summary>true if the potential length of the latest leaf's internode is positive. Used to test for the beginning stem expension</summary>
        public static  VarInfo IsLatestLeafInternodeLengthPotPositive
        {
            get
            {
                return  _IsLatestLeafInternodeLengthPotPositive;
            }
        }
        
        /// <summary>Dictionnary containing for each stage the date it occurs as well as a copy of all types of cumulated thermal times</summary>
        public static  VarInfo Calendar
        {
            get
            {
                return  _Calendar;
            }
        }
        
        /// <summary>Actual number of phytomers</summary>
        public static  VarInfo LeafNumber
        {
            get
            {
                return  _LeafNumber;
            }
        }
        
        /// <summary>final leaf number</summary>
        public static  VarInfo FinalLeafNumber
        {
            get
            {
                return  _FinalLeafNumber;
            }
        }
        
        /// <summary>instance of the phase class . You can get the name of the phase using phase.getPhaseAsString(PhaseValue)</summary>
        public static  VarInfo phase_
        {
            get
            {
                return  _phase_;
            }
        }
        
        /// <summary>Phyllochron</summary>
        public static  VarInfo Phyllochron
        {
            get
            {
                return  _Phyllochron;
            }
        }
        
        /// <summary>progression on a 0  to 1 scale of the vernalization</summary>
        public static  VarInfo Vernaprog
        {
            get
            {
                return  _Vernaprog;
            }
        }
        
        /// <summary>true if flag leaf has appeared (leafnumber reached finalLeafNumber)</summary>
        public static  VarInfo HasFlagLeafLiguleAppeared
        {
            get
            {
                return  _HasFlagLeafLiguleAppeared;
            }
        }
        
        /// <summary>minimum final leaf number</summary>
        public static  VarInfo MinFinalNumber
        {
            get
            {
                return  _MinFinalNumber;
            }
        }
        
        /// <summary>true if the last primordium has appeared</summary>
        public static  VarInfo hasLastPrimordiumAppeared
        {
            get
            {
                return  _hasLastPrimordiumAppeared;
            }
        }
        
        /// <summary>true if ZC_39 is regitered in the calendar</summary>
        public static  VarInfo isMomentRegistredZC_39
        {
            get
            {
                return  _isMomentRegistredZC_39;
            }
        }
        
        /// <summary>cumul of the thermal time ( DeltaTT) since the moment ZC_39</summary>
        public static  VarInfo cumulTTFromZC_39
        {
            get
            {
                return  _cumulTTFromZC_39;
            }
        }
        
        /// <summary>cumul of the thermal time (DeltaTT) since the moment ZC_91</summary>
        public static  VarInfo cumulTTFromZC_91
        {
            get
            {
                return  _cumulTTFromZC_91;
            }
        }
        
        /// <summary>cumul of the thermal time (DeltaTT) since the moment ZC_65</summary>
        public static  VarInfo cumulTTFromZC_65
        {
            get
            {
                return  _cumulTTFromZC_65;
            }
        }
        
        /// <summary>current zadok stage see the definition of "GrowthStage" in the Phase class</summary>
        public static  VarInfo currentZadokStage
        {
            get
            {
                return  _currentZadokStage;
            }
        }
        
        /// <summary>true if the zadok stage has changed this time step</summary>
        public static  VarInfo hasZadokStageChanged
        {
            get
            {
                return  _hasZadokStageChanged;
            }
        }
        
        /// <summary>store the amount of new tiller created at each time a new tiller appears</summary>
        public static  VarInfo tilleringProfile
        {
            get
            {
                return  _tilleringProfile;
            }
        }
        
        /// <summary>store the number of tiller for each leaf layer</summary>
        public static  VarInfo leafTillerNumberArray
        {
            get
            {
                return  _leafTillerNumberArray;
            }
        }
        
        /// <summary>shoot number for the whole canopy</summary>
        public static  VarInfo CanopyShootNumber
        {
            get
            {
                return  _CanopyShootNumber;
            }
        }
        
        /// <summary>average shoot number per plant in the canopy</summary>
        public static  VarInfo AverageShootNumberPerPlant
        {
            get
            {
                return  _AverageShootNumberPerPlant;
            }
        }
        
        /// <summary>number of tiller which have appeared</summary>
        public static  VarInfo TillerNumber
        {
            get
            {
                return  _TillerNumber;
            }
        }
        
        /// <summary>Photothermal Quotient</summary>
        public static  VarInfo PTQ
        {
            get
            {
                return  _PTQ;
            }
        }
        
        /// <summary>Phyllochron with sowing date fix</summary>
        public static  VarInfo Fixphyll
        {
            get
            {
                return  _Fixphyll;
            }
        }
        
        /// <summary>Average GAI over TTWindowForPTQ thermal time periode</summary>
        public static  VarInfo GAImean
        {
            get
            {
                return  _GAImean;
            }
        }
        
        /// <summary>List of daily GAI over TTWindowForPTQ thermal time period</summary>
        public static  VarInfo ListGAITTWindowForPTQ
        {
            get
            {
                return  _ListGAITTWindowForPTQ;
            }
        }
        
        /// <summary>Daily Photosyntetically Active Radiation</summary>
        public static  VarInfo PAR
        {
            get
            {
                return  _PAR;
            }
        }
        
        /// <summary>List of Daily PAR during TTWindowForPTQ thermal time period</summary>
        public static  VarInfo ListPARTTWindowForPTQ
        {
            get
            {
                return  _ListPARTTWindowForPTQ;
            }
        }
        
        /// <summary>List of Daily Shoot thermal time during TTWindowForPTQ thermal time period</summary>
        public static  VarInfo ListTTShootTTWindowForPTQ
        {
            get
            {
                return  _ListTTShootTTWindowForPTQ;
            }
        }
        
        /// <summary>Past Maximum GAI</summary>
        public static  VarInfo pastGAI
        {
            get
            {
                return  _pastGAI;
            }
        }
        
        /// <summary>Set VarInfo values</summary>
        static void DescribeVariables()
        {
            //   
            _currentdate.Name = "currentdate";
            _currentdate.Description = "current date";
            _currentdate.MaxValue = -1D;
            _currentdate.MinValue = -1D;
            _currentdate.DefaultValue = -1D;
            _currentdate.Units = "NA";
            _currentdate.URL = "http://";
            _currentdate.ValueType = VarInfoValueTypes.GetInstanceForName("Date");
            //   
            _cumulTT.Name = "cumulTT";
            _cumulTT.Description = "array of the different cumulTT to be saved in the calendar. The first element is " +
                "the one used to advance the phenology";
            _cumulTT.MaxValue = 10000D;
            _cumulTT.MinValue = 0D;
            _cumulTT.DefaultValue = 0D;
            _cumulTT.Units = "°Cd";
            _cumulTT.URL = "http://";
            _cumulTT.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _DayLength.Name = "DayLength";
            _DayLength.Description = "length of the day";
            _DayLength.MaxValue = 24D;
            _DayLength.MinValue = 0D;
            _DayLength.DefaultValue = 12D;
            _DayLength.Units = "hours";
            _DayLength.URL = "http://";
            _DayLength.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _DeltaTT.Name = "DeltaTT";
            _DeltaTT.Description = "daily delta TT . It is the same kind of TT as cumulTT[0]";
            _DeltaTT.MaxValue = 100D;
            _DeltaTT.MinValue = 0D;
            _DeltaTT.DefaultValue = 0D;
            _DeltaTT.Units = "°Cd";
            _DeltaTT.URL = "http://";
            _DeltaTT.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _GrainCumulTT.Name = "GrainCumulTT";
            _GrainCumulTT.Description = "cumulTT used for the grain developpment";
            _GrainCumulTT.MaxValue = 10000D;
            _GrainCumulTT.MinValue = 0D;
            _GrainCumulTT.DefaultValue = 0D;
            _GrainCumulTT.Units = "°Cd";
            _GrainCumulTT.URL = "http://";
            _GrainCumulTT.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _GAI.Name = "GAI";
            _GAI.Description = "green area index";
            _GAI.MaxValue = 10000D;
            _GAI.MinValue = 0D;
            _GAI.DefaultValue = 0D;
            _GAI.Units = "m²/m²";
            _GAI.URL = "http://";
            _GAI.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _IsLatestLeafInternodeLengthPotPositive.Name = "IsLatestLeafInternodeLengthPotPositive";
            _IsLatestLeafInternodeLengthPotPositive.Description = "true if the potential length of the latest leaf\'s internode is positive. Used to " +
                "test for the beginning stem expension";
            _IsLatestLeafInternodeLengthPotPositive.MaxValue = 1D;
            _IsLatestLeafInternodeLengthPotPositive.MinValue = 0D;
            _IsLatestLeafInternodeLengthPotPositive.DefaultValue = 0D;
            _IsLatestLeafInternodeLengthPotPositive.Units = "NA";
            _IsLatestLeafInternodeLengthPotPositive.URL = "http://";
            _IsLatestLeafInternodeLengthPotPositive.ValueType = VarInfoValueTypes.GetInstanceForName("Integer");
            //   
            _Calendar.Name = "Calendar";
            _Calendar.Description = "Dictionnary containing for each stage the date it occurs as well as a copy of all" +
                " types of cumulated thermal times";
            _Calendar.MaxValue = -1D;
            _Calendar.MinValue = -1D;
            _Calendar.DefaultValue = -1D;
            _Calendar.Units = "NA";
            _Calendar.URL = "http://";
            _Calendar.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _LeafNumber.Name = "LeafNumber";
            _LeafNumber.Description = "Actual number of phytomers";
            _LeafNumber.MaxValue = 25D;
            _LeafNumber.MinValue = 0D;
            _LeafNumber.DefaultValue = 0D;
            _LeafNumber.Units = "leaf";
            _LeafNumber.URL = "http://";
            _LeafNumber.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _FinalLeafNumber.Name = "FinalLeafNumber";
            _FinalLeafNumber.Description = "final leaf number";
            _FinalLeafNumber.MaxValue = 25D;
            _FinalLeafNumber.MinValue = 0D;
            _FinalLeafNumber.DefaultValue = 0D;
            _FinalLeafNumber.Units = "leaf";
            _FinalLeafNumber.URL = "http://";
            _FinalLeafNumber.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _phase_.Name = "phase_";
            _phase_.Description = "instance of the phase class . You can get the name of the phase using phase.getPh" +
                "aseAsString(PhaseValue)";
            _phase_.MaxValue = 7D;
            _phase_.MinValue = 0D;
            _phase_.DefaultValue = 0D;
            _phase_.Units = "NA";
            _phase_.URL = "http://";
            _phase_.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _Phyllochron.Name = "Phyllochron";
            _Phyllochron.Description = "Phyllochron";
            _Phyllochron.MaxValue = 25D;
            _Phyllochron.MinValue = 0D;
            _Phyllochron.DefaultValue = 0D;
            _Phyllochron.Units = "NA";
            _Phyllochron.URL = "http://";
            _Phyllochron.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _Vernaprog.Name = "Vernaprog";
            _Vernaprog.Description = "progression on a 0  to 1 scale of the vernalization";
            _Vernaprog.MaxValue = 1D;
            _Vernaprog.MinValue = 0D;
            _Vernaprog.DefaultValue = 0D;
            _Vernaprog.Units = "NA";
            _Vernaprog.URL = "http://";
            _Vernaprog.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _HasFlagLeafLiguleAppeared.Name = "HasFlagLeafLiguleAppeared";
            _HasFlagLeafLiguleAppeared.Description = "true if flag leaf has appeared (leafnumber reached finalLeafNumber)";
            _HasFlagLeafLiguleAppeared.MaxValue = 1D;
            _HasFlagLeafLiguleAppeared.MinValue = 0D;
            _HasFlagLeafLiguleAppeared.DefaultValue = 0D;
            _HasFlagLeafLiguleAppeared.Units = "NA";
            _HasFlagLeafLiguleAppeared.URL = "http://";
            _HasFlagLeafLiguleAppeared.ValueType = VarInfoValueTypes.GetInstanceForName("Integer");
            //   
            _MinFinalNumber.Name = "MinFinalNumber";
            _MinFinalNumber.Description = "minimum final leaf number";
            _MinFinalNumber.MaxValue = 25D;
            _MinFinalNumber.MinValue = 0D;
            _MinFinalNumber.DefaultValue = 0D;
            _MinFinalNumber.Units = "leaf";
            _MinFinalNumber.URL = "http://";
            _MinFinalNumber.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _hasLastPrimordiumAppeared.Name = "hasLastPrimordiumAppeared";
            _hasLastPrimordiumAppeared.Description = "true if the last primordium has appeared";
            _hasLastPrimordiumAppeared.MaxValue = 1D;
            _hasLastPrimordiumAppeared.MinValue = 0D;
            _hasLastPrimordiumAppeared.DefaultValue = 0D;
            _hasLastPrimordiumAppeared.Units = "NA";
            _hasLastPrimordiumAppeared.URL = "http://";
            _hasLastPrimordiumAppeared.ValueType = VarInfoValueTypes.GetInstanceForName("Integer");
            //   
            _isMomentRegistredZC_39.Name = "isMomentRegistredZC_39";
            _isMomentRegistredZC_39.Description = "true if ZC_39 is regitered in the calendar";
            _isMomentRegistredZC_39.MaxValue = 1D;
            _isMomentRegistredZC_39.MinValue = 0D;
            _isMomentRegistredZC_39.DefaultValue = 0D;
            _isMomentRegistredZC_39.Units = "NA";
            _isMomentRegistredZC_39.URL = "http://";
            _isMomentRegistredZC_39.ValueType = VarInfoValueTypes.GetInstanceForName("Integer");
            //   
            _cumulTTFromZC_39.Name = "cumulTTFromZC_39";
            _cumulTTFromZC_39.Description = "cumul of the thermal time ( DeltaTT) since the moment ZC_39";
            _cumulTTFromZC_39.MaxValue = 10000D;
            _cumulTTFromZC_39.MinValue = 0D;
            _cumulTTFromZC_39.DefaultValue = 0D;
            _cumulTTFromZC_39.Units = "°C/d";
            _cumulTTFromZC_39.URL = "http://";
            _cumulTTFromZC_39.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _cumulTTFromZC_91.Name = "cumulTTFromZC_91";
            _cumulTTFromZC_91.Description = "cumul of the thermal time (DeltaTT) since the moment ZC_91";
            _cumulTTFromZC_91.MaxValue = 10000D;
            _cumulTTFromZC_91.MinValue = 0D;
            _cumulTTFromZC_91.DefaultValue = 0D;
            _cumulTTFromZC_91.Units = "°C/d";
            _cumulTTFromZC_91.URL = "http://";
            _cumulTTFromZC_91.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _cumulTTFromZC_65.Name = "cumulTTFromZC_65";
            _cumulTTFromZC_65.Description = "cumul of the thermal time (DeltaTT) since the moment ZC_65";
            _cumulTTFromZC_65.MaxValue = 10000D;
            _cumulTTFromZC_65.MinValue = 0D;
            _cumulTTFromZC_65.DefaultValue = 0D;
            _cumulTTFromZC_65.Units = "°C/d";
            _cumulTTFromZC_65.URL = "http://";
            _cumulTTFromZC_65.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _currentZadokStage.Name = "currentZadokStage";
            _currentZadokStage.Description = "current zadok stage see the definition of \"GrowthStage\" in the Phase class";
            _currentZadokStage.MaxValue = 20D;
            _currentZadokStage.MinValue = 0D;
            _currentZadokStage.DefaultValue = 0D;
            _currentZadokStage.Units = "NA";
            _currentZadokStage.URL = "http://";
            _currentZadokStage.ValueType = VarInfoValueTypes.GetInstanceForName("Integer");
            //   
            _hasZadokStageChanged.Name = "hasZadokStageChanged";
            _hasZadokStageChanged.Description = "true if the zadok stage has changed this time step";
            _hasZadokStageChanged.MaxValue = 1D;
            _hasZadokStageChanged.MinValue = 0D;
            _hasZadokStageChanged.DefaultValue = 0D;
            _hasZadokStageChanged.Units = "NA";
            _hasZadokStageChanged.URL = "http://";
            _hasZadokStageChanged.ValueType = VarInfoValueTypes.GetInstanceForName("Integer");
            //   
            _tilleringProfile.Name = "tilleringProfile";
            _tilleringProfile.Description = "store the amount of new tiller created at each time a new tiller appears";
            _tilleringProfile.MaxValue = 0D;
            _tilleringProfile.MinValue = 0D;
            _tilleringProfile.DefaultValue = 0D;
            _tilleringProfile.Units = "NA";
            _tilleringProfile.URL = "http://";
            _tilleringProfile.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _leafTillerNumberArray.Name = "leafTillerNumberArray";
            _leafTillerNumberArray.Description = "store the number of tiller for each leaf layer";
            _leafTillerNumberArray.MaxValue = 0D;
            _leafTillerNumberArray.MinValue = 0D;
            _leafTillerNumberArray.DefaultValue = 0D;
            _leafTillerNumberArray.Units = "NA";
            _leafTillerNumberArray.URL = "http://";
            _leafTillerNumberArray.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _CanopyShootNumber.Name = "CanopyShootNumber";
            _CanopyShootNumber.Description = "shoot number for the whole canopy";
            _CanopyShootNumber.MaxValue = 1000D;
            _CanopyShootNumber.MinValue = 0D;
            _CanopyShootNumber.DefaultValue = 0D;
            _CanopyShootNumber.Units = "shoot/m²";
            _CanopyShootNumber.URL = "http://";
            _CanopyShootNumber.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _AverageShootNumberPerPlant.Name = "AverageShootNumberPerPlant";
            _AverageShootNumberPerPlant.Description = "average shoot number per plant in the canopy";
            _AverageShootNumberPerPlant.MaxValue = 15D;
            _AverageShootNumberPerPlant.MinValue = 0D;
            _AverageShootNumberPerPlant.DefaultValue = 1D;
            _AverageShootNumberPerPlant.Units = "shoot";
            _AverageShootNumberPerPlant.URL = "http://";
            _AverageShootNumberPerPlant.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _TillerNumber.Name = "TillerNumber";
            _TillerNumber.Description = "number of tiller which have appeared";
            _TillerNumber.MaxValue = 15D;
            _TillerNumber.MinValue = 0D;
            _TillerNumber.DefaultValue = 1D;
            _TillerNumber.Units = "shoot";
            _TillerNumber.URL = "http://";
            _TillerNumber.ValueType = VarInfoValueTypes.GetInstanceForName("Integer");
            //   
            _PTQ.Name = "PTQ";
            _PTQ.Description = "Photothermal Quotient";
            _PTQ.MaxValue = 10000D;
            _PTQ.MinValue = 0D;
            _PTQ.DefaultValue = 0D;
            _PTQ.Units = "MJ/(°C.d.m²)";
            _PTQ.URL = "http://";
            _PTQ.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _Fixphyll.Name = "Fixphyll";
            _Fixphyll.Description = "Phyllochron with sowing date fix";
            _Fixphyll.MaxValue = 10000D;
            _Fixphyll.MinValue = 0D;
            _Fixphyll.DefaultValue = 220D;
            _Fixphyll.Units = "°Cd";
            _Fixphyll.URL = "http://";
            _Fixphyll.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _GAImean.Name = "GAImean";
            _GAImean.Description = "Average GAI over TTWindowForPTQ thermal time periode";
            _GAImean.MaxValue = 10000D;
            _GAImean.MinValue = 0D;
            _GAImean.DefaultValue = 0D;
            _GAImean.Units = "m²/m²";
            _GAImean.URL = "http://";
            _GAImean.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _ListGAITTWindowForPTQ.Name = "ListGAITTWindowForPTQ";
            _ListGAITTWindowForPTQ.Description = "List of daily GAI over TTWindowForPTQ thermal time period";
            _ListGAITTWindowForPTQ.MaxValue = 10000D;
            _ListGAITTWindowForPTQ.MinValue = 0D;
            _ListGAITTWindowForPTQ.DefaultValue = 0D;
            _ListGAITTWindowForPTQ.Units = "m²/m²";
            _ListGAITTWindowForPTQ.URL = "http://";
            _ListGAITTWindowForPTQ.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _PAR.Name = "PAR";
            _PAR.Description = "Daily Photosyntetically Active Radiation";
            _PAR.MaxValue = 1000D;
            _PAR.MinValue = 0D;
            _PAR.DefaultValue = 0D;
            _PAR.Units = "MJ/m²/d";
            _PAR.URL = "http://";
            _PAR.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _ListPARTTWindowForPTQ.Name = "ListPARTTWindowForPTQ";
            _ListPARTTWindowForPTQ.Description = "List of Daily PAR during TTWindowForPTQ thermal time period";
            _ListPARTTWindowForPTQ.MaxValue = 1000D;
            _ListPARTTWindowForPTQ.MinValue = 0D;
            _ListPARTTWindowForPTQ.DefaultValue = 0D;
            _ListPARTTWindowForPTQ.Units = "MJ/m²/d";
            _ListPARTTWindowForPTQ.URL = "http://";
            _ListPARTTWindowForPTQ.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _ListTTShootTTWindowForPTQ.Name = "ListTTShootTTWindowForPTQ";
            _ListTTShootTTWindowForPTQ.Description = "List of Daily Shoot thermal time during TTWindowForPTQ thermal time period";
            _ListTTShootTTWindowForPTQ.MaxValue = 70000D;
            _ListTTShootTTWindowForPTQ.MinValue = 0D;
            _ListTTShootTTWindowForPTQ.DefaultValue = 0D;
            _ListTTShootTTWindowForPTQ.Units = "°Cd";
            _ListTTShootTTWindowForPTQ.URL = "http://";
            _ListTTShootTTWindowForPTQ.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _pastGAI.Name = "pastGAI";
            _pastGAI.Description = "Past Maximum GAI";
            _pastGAI.MaxValue = 10000D;
            _pastGAI.MinValue = 0D;
            _pastGAI.DefaultValue = 0D;
            _pastGAI.Units = "m²/m²";
            _pastGAI.URL = "http://";
            _pastGAI.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
        }
    }
}
