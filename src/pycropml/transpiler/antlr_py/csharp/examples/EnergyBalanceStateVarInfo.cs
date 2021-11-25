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
/// This class was created from file C:\Users\mancealo\Documents\Sirius Quality\branches\Development2\Code\SiriusQuality-EnergyBalanceComponent\XML\SiriusQualityEnergyBalance_EnergyBalanceState.xml
/// The tool used was: DCC - Domain Class Coder, http://components.biomamodelling.org/, DCC
/// 
/// Loic Manceau
/// loic.manceau@inra.fr
/// INRA
/// 
/// 
/// 5/14/2018 1:11:42 PM
/// 
namespace SiriusQualityEnergyBalance
{
    using System;
    using CRA.ModelLayer.Core;
    
    
    /// <summary>EnergyBalanceStateVarInfoClasses contain the attributes for each variable in the domain class RainData. Attributes are valorized via the static constructor. The data-type VarInfo causes  a dependency to the assembly CRA.Core.Preconditions.dll</summary>
    public class EnergyBalanceStateVarInfo : IVarInfoClass
    {
        

        static VarInfo _deficitOnTopLayers = new VarInfo();
        
        static VarInfo _minTair = new VarInfo();
        
        static VarInfo _maxTair = new VarInfo();
        
        static VarInfo _hourlyTemp = new VarInfo();
        
        static VarInfo _solarRadiation = new VarInfo();
        
        static VarInfo _extraSolarRadiation = new VarInfo();
        
        static VarInfo _vaporPressure = new VarInfo();
        
        static VarInfo _tau = new VarInfo();
        
        static VarInfo _hslope = new VarInfo();
        
        static VarInfo _plantHeight = new VarInfo();
        
        static VarInfo _wind = new VarInfo();
        
        static VarInfo _VPDair = new VarInfo();
        
        static VarInfo _isWindVpDefined = new VarInfo();
        
        static VarInfo _elevation = new VarInfo();
        
        static VarInfo _netRadiation = new VarInfo();
        
        static VarInfo _diffusionLimitedEvaporation = new VarInfo();
        
        static VarInfo _energyLimitedEvaporation = new VarInfo();
        
        static VarInfo _evapoTranspirationPriestlyTaylor = new VarInfo();
        
        static VarInfo _evapoTranspirationPenman = new VarInfo();
        
        static VarInfo _potentialTranspiration = new VarInfo();
        
        static VarInfo _conductance = new VarInfo();
        
        static VarInfo _soilEvaporation = new VarInfo();
        
        static VarInfo _potentialEvapoTranspiration = new VarInfo();
        
        static VarInfo _soilHeatFlux = new VarInfo();
        
        static VarInfo _cropHeatFlux = new VarInfo();
        
        static VarInfo _minCanopyTemperature = new VarInfo();
        
        static VarInfo _maxCanopyTemperature = new VarInfo();
        
        static VarInfo _hourlyCanopyTemperature = new VarInfo();
        
        static VarInfo _evapoTranspiration = new VarInfo();
        
        static VarInfo _hourlyVPDair = new VarInfo();
        
        static VarInfo _hourlySolarRadiation = new VarInfo();
        
        static VarInfo _wc3cm = new VarInfo();
        
        static VarInfo _Ntip = new VarInfo();
        
        static VarInfo _netRadiationEquivalentEvaporation = new VarInfo();
        
        static VarInfo _RH = new VarInfo();
        
        static VarInfo _hourlyVPDairLeaf = new VarInfo();
        
        static VarInfo _VPDeq = new VarInfo();
        
        static VarInfo _netOutGoingLongWaveRadiation = new VarInfo();

        /// <summary>Constructor</summary>
        static EnergyBalanceStateVarInfo()
        {
            EnergyBalanceStateVarInfo.DescribeVariables();
        }
        
        /// <summary>Domain Class description</summary>
        public virtual  string Description
        {
            get
            {
                return "Domain class for the energy bakance component of Sirius Quality";
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
                return "EnergyBalanceState";
            }
        }

        

        /// <summary>deficitOnTopLayers</summary>
        public static  VarInfo deficitOnTopLayers
        {
            get
            {
                return  _deficitOnTopLayers;
            }
        }
        
        /// <summary>minimum air temperature</summary>
        public static  VarInfo minTair
        {
            get
            {
                return  _minTair;
            }
        }
        
        /// <summary>maximum air temperature</summary>
        public static  VarInfo maxTair
        {
            get
            {
                return  _maxTair;
            }
        }
        
        /// <summary>hourly temperature</summary>
        public static  VarInfo hourlyTemp
        {
            get
            {
                return  _hourlyTemp;
            }
        }
        
        /// <summary>solarRadiation</summary>
        public static  VarInfo solarRadiation
        {
            get
            {
                return  _solarRadiation;
            }
        }
        
        /// <summary>extra solar raidation</summary>
        public static  VarInfo extraSolarRadiation
        {
            get
            {
                return  _extraSolarRadiation;
            }
        }
        
        /// <summary>vapor pressure</summary>
        public static  VarInfo vaporPressure
        {
            get
            {
                return  _vaporPressure;
            }
        }
        
        /// <summary>tau</summary>
        public static  VarInfo tau
        {
            get
            {
                return  _tau;
            }
        }
        
        /// <summary>hslope</summary>
        public static  VarInfo hslope
        {
            get
            {
                return  _hslope;
            }
        }
        
        /// <summary>plant height</summary>
        public static  VarInfo plantHeight
        {
            get
            {
                return  _plantHeight;
            }
        }
        
        /// <summary>wind</summary>
        public static  VarInfo wind
        {
            get
            {
                return  _wind;
            }
        }
        
        /// <summary>vpd</summary>
        public static  VarInfo VPDair
        {
            get
            {
                return  _VPDair;
            }
        }
        
        /// <summary>isWindVpDefined</summary>
        public static  VarInfo isWindVpDefined
        {
            get
            {
                return  _isWindVpDefined;
            }
        }
        
        /// <summary>elevation</summary>
        public static  VarInfo elevation
        {
            get
            {
                return  _elevation;
            }
        }
        
        /// <summary>netRadiation</summary>
        public static  VarInfo netRadiation
        {
            get
            {
                return  _netRadiation;
            }
        }
        
        /// <summary>diffusionLimitedEvaporation</summary>
        public static  VarInfo diffusionLimitedEvaporation
        {
            get
            {
                return  _diffusionLimitedEvaporation;
            }
        }
        
        /// <summary>energyLimitedEvaporation</summary>
        public static  VarInfo energyLimitedEvaporation
        {
            get
            {
                return  _energyLimitedEvaporation;
            }
        }
        
        /// <summary>evapoTranspirationPriestlyTaylor</summary>
        public static  VarInfo evapoTranspirationPriestlyTaylor
        {
            get
            {
                return  _evapoTranspirationPriestlyTaylor;
            }
        }
        
        /// <summary>evapoTranspirationPenman</summary>
        public static  VarInfo evapoTranspirationPenman
        {
            get
            {
                return  _evapoTranspirationPenman;
            }
        }
        
        /// <summary>potentialTranspiration</summary>
        public static  VarInfo potentialTranspiration
        {
            get
            {
                return  _potentialTranspiration;
            }
        }
        
        /// <summary>conductance</summary>
        public static  VarInfo conductance
        {
            get
            {
                return  _conductance;
            }
        }
        
        /// <summary>soilEvaporation</summary>
        public static  VarInfo soilEvaporation
        {
            get
            {
                return  _soilEvaporation;
            }
        }
        
        /// <summary>PotentialEvapoTranspiration</summary>
        public static  VarInfo potentialEvapoTranspiration
        {
            get
            {
                return  _potentialEvapoTranspiration;
            }
        }
        
        /// <summary>soilHeatFlux</summary>
        public static  VarInfo soilHeatFlux
        {
            get
            {
                return  _soilHeatFlux;
            }
        }
        
        /// <summary>cropHeatFlux</summary>
        public static  VarInfo cropHeatFlux
        {
            get
            {
                return  _cropHeatFlux;
            }
        }
        
        /// <summary>minCanopyTemperature</summary>
        public static  VarInfo minCanopyTemperature
        {
            get
            {
                return  _minCanopyTemperature;
            }
        }
        
        /// <summary>maxCanopyTemperature</summary>
        public static  VarInfo maxCanopyTemperature
        {
            get
            {
                return  _maxCanopyTemperature;
            }
        }
        
        /// <summary>hourlyCanopyTemperature (maize)</summary>
        public static  VarInfo hourlyCanopyTemperature
        {
            get
            {
                return  _hourlyCanopyTemperature;
            }
        }
        
        /// <summary>evapoTranspiration</summary>
        public static  VarInfo evapoTranspiration
        {
            get
            {
                return  _evapoTranspiration;
            }
        }
        
        /// <summary>hourlyVPDair (maize)</summary>
        public static  VarInfo hourlyVPDair
        {
            get
            {
                return  _hourlyVPDair;
            }
        }
        
        /// <summary>hourlySolarRadiation( maize)</summary>
        public static  VarInfo hourlySolarRadiation
        {
            get
            {
                return  _hourlySolarRadiation;
            }
        }
        
        /// <summary>water cotent in the first 3 cm</summary>
        public static  VarInfo wc3cm
        {
            get
            {
                return  _wc3cm;
            }
        }
        
        /// <summary>number of leaves (tip) (maize)</summary>
        public static  VarInfo Ntip
        {
            get
            {
                return  _Ntip;
            }
        }
        
        /// <summary>netRadiationEquivalentEvaporation</summary>
        public static  VarInfo netRadiationEquivalentEvaporation
        {
            get
            {
                return  _netRadiationEquivalentEvaporation;
            }
        }
        
        /// <summary>hourly relative humidity</summary>
        public static  VarInfo RH
        {
            get
            {
                return  _RH;
            }
        }
        
        /// <summary>hourlyVPDairLEaf (maize)</summary>
        public static  VarInfo hourlyVPDairLeaf
        {
            get
            {
                return  _hourlyVPDairLeaf;
            }
        }
        
        /// <summary>VPDeq (maize)</summary>
        public static  VarInfo VPDeq
        {
            get
            {
                return  _VPDeq;
            }
        }
        
        /// <summary>OutGoing Net Longwave Radaition</summary>
        public static  VarInfo netOutGoingLongWaveRadiation
        {
            get
            {
                return  _netOutGoingLongWaveRadiation;
            }
        }

        

        /// <summary>Set VarInfo values</summary>
        static void DescribeVariables()
        {
            //   
            _deficitOnTopLayers.Name = "deficitOnTopLayers";
            _deficitOnTopLayers.Description = "deficitOnTopLayers";
            _deficitOnTopLayers.MaxValue = 100D;
            _deficitOnTopLayers.MinValue = 0D;
            _deficitOnTopLayers.DefaultValue = 50D;
            _deficitOnTopLayers.Units = "g.m-2.d-1";
            _deficitOnTopLayers.URL = "http://";
            _deficitOnTopLayers.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _minTair.Name = "minTair";
            _minTair.Description = "minimum air temperature";
            _minTair.MaxValue = 40D;
            _minTair.MinValue = -40D;
            _minTair.DefaultValue = 10D;
            _minTair.Units = "degree celsius";
            _minTair.URL = "http://";
            _minTair.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _maxTair.Name = "maxTair";
            _maxTair.Description = "maximum air temperature";
            _maxTair.MaxValue = 50D;
            _maxTair.MinValue = -30D;
            _maxTair.DefaultValue = 20D;
            _maxTair.Units = "degree celsius";
            _maxTair.URL = "http://";
            _maxTair.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _hourlyTemp.Name = "hourlyTemp";
            _hourlyTemp.Description = "hourly temperature";
            _hourlyTemp.MaxValue = 50D;
            _hourlyTemp.MinValue = -40D;
            _hourlyTemp.DefaultValue = 15D;
            _hourlyTemp.Units = "degree celsius";
            _hourlyTemp.URL = "http://";
            _hourlyTemp.ValueType = VarInfoValueTypes.GetInstanceForName("ArrayDouble");
            //   
            _solarRadiation.Name = "solarRadiation";
            _solarRadiation.Description = "solarRadiation";
            _solarRadiation.MaxValue = 1000D;
            _solarRadiation.MinValue = 0D;
            _solarRadiation.DefaultValue = 100D;
            _solarRadiation.Units = "MJ m-2 d-1";
            _solarRadiation.URL = "http://";
            _solarRadiation.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _extraSolarRadiation.Name = "extraSolarRadiation";
            _extraSolarRadiation.Description = "extra solar raidation";
            _extraSolarRadiation.MaxValue = 1000D;
            _extraSolarRadiation.MinValue = 0D;
            _extraSolarRadiation.DefaultValue = 100D;
            _extraSolarRadiation.Units = "MJ m-2 d-1";
            _extraSolarRadiation.URL = "http://";
            _extraSolarRadiation.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _vaporPressure.Name = "vaporPressure";
            _vaporPressure.Description = "vapor pressure";
            _vaporPressure.MaxValue = 1000D;
            _vaporPressure.MinValue = 0D;
            _vaporPressure.DefaultValue = 100D;
            _vaporPressure.Units = "P";
            _vaporPressure.URL = "http://";
            _vaporPressure.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _tau.Name = "tau";
            _tau.Description = "tau";
            _tau.MaxValue = 1D;
            _tau.MinValue = 0D;
            _tau.DefaultValue = 0.5D;
            _tau.Units = "dimensionless";
            _tau.URL = "http://";
            _tau.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _hslope.Name = "hslope";
            _hslope.Description = "hslope";
            _hslope.MaxValue = 20D;
            _hslope.MinValue = 0D;
            _hslope.DefaultValue = 10D;
            _hslope.Units = "dimensionless";
            _hslope.URL = "http://";
            _hslope.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _plantHeight.Name = "plantHeight";
            _plantHeight.Description = "plant height";
            _plantHeight.MaxValue = 1000D;
            _plantHeight.MinValue = 0D;
            _plantHeight.DefaultValue = 50D;
            _plantHeight.Units = "cm";
            _plantHeight.URL = "http://";
            _plantHeight.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _wind.Name = "wind";
            _wind.Description = "wind";
            _wind.MaxValue = 1000D;
            _wind.MinValue = 0D;
            _wind.DefaultValue = 100D;
            _wind.Units = "m-1";
            _wind.URL = "http://";
            _wind.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _VPDair.Name = "VPDair";
            _VPDair.Description = "vpd";
            _VPDair.MaxValue = 100D;
            _VPDair.MinValue = 0D;
            _VPDair.DefaultValue = 50D;
            _VPDair.Units = "hPa";
            _VPDair.URL = "http://";
            _VPDair.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _isWindVpDefined.Name = "isWindVpDefined";
            _isWindVpDefined.Description = "isWindVpDefined";
            _isWindVpDefined.MaxValue = 1D;
            _isWindVpDefined.MinValue = 0D;
            _isWindVpDefined.DefaultValue = 1D;
            _isWindVpDefined.Units = "dimensionless";
            _isWindVpDefined.URL = "http://";
            _isWindVpDefined.ValueType = VarInfoValueTypes.GetInstanceForName("Integer");
            //   
            _elevation.Name = "elevation";
            _elevation.Description = "elevation";
            _elevation.MaxValue = 1000D;
            _elevation.MinValue = 0D;
            _elevation.DefaultValue = 100D;
            _elevation.Units = "m";
            _elevation.URL = "http://";
            _elevation.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _netRadiation.Name = "netRadiation";
            _netRadiation.Description = "netRadiation";
            _netRadiation.MaxValue = 100D;
            _netRadiation.MinValue = 0D;
            _netRadiation.DefaultValue = 50D;
            _netRadiation.Units = "MJ.m-2.d-1";
            _netRadiation.URL = "http://";
            _netRadiation.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _diffusionLimitedEvaporation.Name = "diffusionLimitedEvaporation";
            _diffusionLimitedEvaporation.Description = "diffusionLimitedEvaporation";
            _diffusionLimitedEvaporation.MaxValue = 100D;
            _diffusionLimitedEvaporation.MinValue = 0D;
            _diffusionLimitedEvaporation.DefaultValue = 50D;
            _diffusionLimitedEvaporation.Units = "g m-2 d-1";
            _diffusionLimitedEvaporation.URL = "http://";
            _diffusionLimitedEvaporation.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _energyLimitedEvaporation.Name = "energyLimitedEvaporation";
            _energyLimitedEvaporation.Description = "energyLimitedEvaporation";
            _energyLimitedEvaporation.MaxValue = 1000D;
            _energyLimitedEvaporation.MinValue = 0D;
            _energyLimitedEvaporation.DefaultValue = 500D;
            _energyLimitedEvaporation.Units = "g m-2 d-1";
            _energyLimitedEvaporation.URL = "http://";
            _energyLimitedEvaporation.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _evapoTranspirationPriestlyTaylor.Name = "evapoTranspirationPriestlyTaylor";
            _evapoTranspirationPriestlyTaylor.Description = "evapoTranspirationPriestlyTaylor";
            _evapoTranspirationPriestlyTaylor.MaxValue = 50D;
            _evapoTranspirationPriestlyTaylor.MinValue = 0D;
            _evapoTranspirationPriestlyTaylor.DefaultValue = 30D;
            _evapoTranspirationPriestlyTaylor.Units = "g m-2 d-1";
            _evapoTranspirationPriestlyTaylor.URL = "http://";
            _evapoTranspirationPriestlyTaylor.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _evapoTranspirationPenman.Name = "evapoTranspirationPenman";
            _evapoTranspirationPenman.Description = "evapoTranspirationPenman";
            _evapoTranspirationPenman.MaxValue = 100D;
            _evapoTranspirationPenman.MinValue = 0D;
            _evapoTranspirationPenman.DefaultValue = 50D;
            _evapoTranspirationPenman.Units = "g m-2 d-1";
            _evapoTranspirationPenman.URL = "http://";
            _evapoTranspirationPenman.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _potentialTranspiration.Name = "potentialTranspiration";
            _potentialTranspiration.Description = "potentialTranspiration";
            _potentialTranspiration.MaxValue = 100D;
            _potentialTranspiration.MinValue = 0D;
            _potentialTranspiration.DefaultValue = 50D;
            _potentialTranspiration.Units = "g m-2 d-1";
            _potentialTranspiration.URL = "http://";
            _potentialTranspiration.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _conductance.Name = "conductance";
            _conductance.Description = "conductance";
            _conductance.MaxValue = 100D;
            _conductance.MinValue = 0D;
            _conductance.DefaultValue = 50D;
            _conductance.Units = "m d-1";
            _conductance.URL = "http://";
            _conductance.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _soilEvaporation.Name = "soilEvaporation";
            _soilEvaporation.Description = "soilEvaporation";
            _soilEvaporation.MaxValue = 100D;
            _soilEvaporation.MinValue = 0D;
            _soilEvaporation.DefaultValue = 50D;
            _soilEvaporation.Units = "g m-2 d-1";
            _soilEvaporation.URL = "http://";
            _soilEvaporation.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _potentialEvapoTranspiration.Name = "potentialEvapoTranspiration";
            _potentialEvapoTranspiration.Description = "PotentialEvapoTranspiration";
            _potentialEvapoTranspiration.MaxValue = 100D;
            _potentialEvapoTranspiration.MinValue = 0D;
            _potentialEvapoTranspiration.DefaultValue = 50D;
            _potentialEvapoTranspiration.Units = "g m-2 d-1";
            _potentialEvapoTranspiration.URL = "http://";
            _potentialEvapoTranspiration.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _soilHeatFlux.Name = "soilHeatFlux";
            _soilHeatFlux.Description = "soilHeatFlux";
            _soilHeatFlux.MaxValue = 100D;
            _soilHeatFlux.MinValue = 0D;
            _soilHeatFlux.DefaultValue = 50D;
            _soilHeatFlux.Units = "g m-2 d-1";
            _soilHeatFlux.URL = "http://";
            _soilHeatFlux.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _cropHeatFlux.Name = "cropHeatFlux";
            _cropHeatFlux.Description = "cropHeatFlux";
            _cropHeatFlux.MaxValue = 100D;
            _cropHeatFlux.MinValue = 0D;
            _cropHeatFlux.DefaultValue = 50D;
            _cropHeatFlux.Units = "g m-2 d-1";
            _cropHeatFlux.URL = "http://";
            _cropHeatFlux.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _minCanopyTemperature.Name = "minCanopyTemperature";
            _minCanopyTemperature.Description = "minCanopyTemperature";
            _minCanopyTemperature.MaxValue = 50D;
            _minCanopyTemperature.MinValue = -30D;
            _minCanopyTemperature.DefaultValue = 10D;
            _minCanopyTemperature.Units = "degree celsius";
            _minCanopyTemperature.URL = "http://";
            _minCanopyTemperature.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _maxCanopyTemperature.Name = "maxCanopyTemperature";
            _maxCanopyTemperature.Description = "maxCanopyTemperature";
            _maxCanopyTemperature.MaxValue = 50D;
            _maxCanopyTemperature.MinValue = -30D;
            _maxCanopyTemperature.DefaultValue = 10D;
            _maxCanopyTemperature.Units = "degree celsius";
            _maxCanopyTemperature.URL = "http://";
            _maxCanopyTemperature.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _hourlyCanopyTemperature.Name = "hourlyCanopyTemperature";
            _hourlyCanopyTemperature.Description = "hourlyCanopyTemperature (maize)";
            _hourlyCanopyTemperature.MaxValue = 50D;
            _hourlyCanopyTemperature.MinValue = -30D;
            _hourlyCanopyTemperature.DefaultValue = 10D;
            _hourlyCanopyTemperature.Units = "degree celsius";
            _hourlyCanopyTemperature.URL = "http://";
            _hourlyCanopyTemperature.ValueType = VarInfoValueTypes.GetInstanceForName("ArrayDouble");
            //   
            _evapoTranspiration.Name = "evapoTranspiration";
            _evapoTranspiration.Description = "evapoTranspiration";
            _evapoTranspiration.MaxValue = 50D;
            _evapoTranspiration.MinValue = -30D;
            _evapoTranspiration.DefaultValue = 10D;
            _evapoTranspiration.Units = "g.m-2.d-1";
            _evapoTranspiration.URL = "http://";
            _evapoTranspiration.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _hourlyVPDair.Name = "hourlyVPDair";
            _hourlyVPDair.Description = "hourlyVPDair (maize)";
            _hourlyVPDair.MaxValue = 100D;
            _hourlyVPDair.MinValue = 0D;
            _hourlyVPDair.DefaultValue = 50D;
            _hourlyVPDair.Units = "hPa";
            _hourlyVPDair.URL = "http://";
            _hourlyVPDair.ValueType = VarInfoValueTypes.GetInstanceForName("ArrayDouble");
            //   
            _hourlySolarRadiation.Name = "hourlySolarRadiation";
            _hourlySolarRadiation.Description = "hourlySolarRadiation( maize)";
            _hourlySolarRadiation.MaxValue = 1000D;
            _hourlySolarRadiation.MinValue = 0D;
            _hourlySolarRadiation.DefaultValue = 100D;
            _hourlySolarRadiation.Units = "MJ m-2 d-1";
            _hourlySolarRadiation.URL = "http://";
            _hourlySolarRadiation.ValueType = VarInfoValueTypes.GetInstanceForName("ArrayDouble");
            //   
            _wc3cm.Name = "wc3cm";
            _wc3cm.Description = "water cotent in the first 3 cm";
            _wc3cm.MaxValue = 100D;
            _wc3cm.MinValue = 0D;
            _wc3cm.DefaultValue = 50D;
            _wc3cm.Units = "mm";
            _wc3cm.URL = "http://";
            _wc3cm.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _Ntip.Name = "Ntip";
            _Ntip.Description = "number of leaves (tip) (maize)";
            _Ntip.MaxValue = 30D;
            _Ntip.MinValue = 0D;
            _Ntip.DefaultValue = 15D;
            _Ntip.Units = "leaf";
            _Ntip.URL = "http://";
            _Ntip.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _netRadiationEquivalentEvaporation.Name = "netRadiationEquivalentEvaporation";
            _netRadiationEquivalentEvaporation.Description = "netRadiationEquivalentEvaporation";
            _netRadiationEquivalentEvaporation.MaxValue = 100D;
            _netRadiationEquivalentEvaporation.MinValue = 0D;
            _netRadiationEquivalentEvaporation.DefaultValue = 50D;
            _netRadiationEquivalentEvaporation.Units = "?";
            _netRadiationEquivalentEvaporation.URL = "http://";
            _netRadiationEquivalentEvaporation.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
            //   
            _RH.Name = "RH";
            _RH.Description = "hourly relative humidity";
            _RH.MaxValue = 100D;
            _RH.MinValue = 0D;
            _RH.DefaultValue = 10D;
            _RH.Units = "%";
            _RH.URL = "http://";
            _RH.ValueType = VarInfoValueTypes.GetInstanceForName("ArrayDouble");
            //   
            _hourlyVPDairLeaf.Name = "hourlyVPDairLeaf";
            _hourlyVPDairLeaf.Description = "hourlyVPDairLEaf (maize)";
            _hourlyVPDairLeaf.MaxValue = 100D;
            _hourlyVPDairLeaf.MinValue = 0D;
            _hourlyVPDairLeaf.DefaultValue = 50D;
            _hourlyVPDairLeaf.Units = "hPa";
            _hourlyVPDairLeaf.URL = "http://";
            _hourlyVPDairLeaf.ValueType = VarInfoValueTypes.GetInstanceForName("ArrayDouble");
            //   
            _VPDeq.Name = "VPDeq";
            _VPDeq.Description = "VPDeq (maize)";
            _VPDeq.MaxValue = 100D;
            _VPDeq.MinValue = 0D;
            _VPDeq.DefaultValue = 50D;
            _VPDeq.Units = "hPa";
            _VPDeq.URL = "http://";
            _VPDeq.ValueType = VarInfoValueTypes.GetInstanceForName("ArrayDouble");
            //   
            _netOutGoingLongWaveRadiation.Name = "netOutGoingLongWaveRadiation";
            _netOutGoingLongWaveRadiation.Description = "OutGoing Net Longwave Radaition";
            _netOutGoingLongWaveRadiation.MaxValue = 100D;
            _netOutGoingLongWaveRadiation.MinValue = 0D;
            _netOutGoingLongWaveRadiation.DefaultValue = 50D;
            _netOutGoingLongWaveRadiation.Units = "MJ.m-2.d-1";
            _netOutGoingLongWaveRadiation.URL = "http://";
            _netOutGoingLongWaveRadiation.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
        }

    }
}
