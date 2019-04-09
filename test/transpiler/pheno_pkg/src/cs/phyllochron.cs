using System;
using System.Collections.Generic;
public class Phyllochron_
{
    public static Tuple<double,double>  phyllochron_(double fixPhyll,double leafNumber,double lincr,double ldecr,double pdecr,double pincr,double ptq,double gai,double pastMaxAI,double kl,double aPTQ,double phylPTQ1,double p,string choosePhyllUse)
    {
        //- Description:
    //            - Model Name: Phyllochron Model
    //            - Author: Pierre Martre
    //            - Reference: Modeling development phase in the 
    //                Wheat Simulation Model SiriusQuality.
    //                See documentation at http://www1.clermont.inra.fr/siriusquality/?page_id=427
    //            - Institution: INRA Montpellier
    //            - Abstract: Calculate different types of phyllochron 
        //- inputs:
    //            - name: fixPhyll
    //                          - min : 0
    //                          - default : 5
    //                          - max : 10000
    //                          - uri : some url
    //                          - variablecategory : auxiliary
    //                          - datatype : DOUBLE
    //                          - inputtype : variable
    //                          - unit : °C d leaf-1
    //                          - description : Sowing date corrected Phyllochron
    //            - name: leafNumber
    //                          - min : 0
    //                          - default : 0
    //                          - max : 25
    //                          - uri : some url
    //                          - variablecategory : state
    //                          - datatype : DOUBLE
    //                          - inputtype : variable
    //                          - unit : leaf
    //                          - description : Actual number of phytomers
    //            - name: lincr
    //                          - parametercategory : species
    //                          - min : 0
    //                          - datatype : DOUBLE
    //                          - max : 30
    //                          - uri : some url
    //                          - default : 8
    //                          - inputtype : parameter
    //                          - unit : leaf
    //                          - description : Leaf number above which the phyllochron is increased by Pincr
    //            - name: ldecr
    //                          - parametercategory : species
    //                          - min : 0
    //                          - datatype : DOUBLE
    //                          - max : 30
    //                          - uri : some url
    //                          - default : 10
    //                          - inputtype : parameter
    //                          - unit : leaf
    //                          - description : Leaf number up to which the phyllochron is decreased by Pdecr
    //            - name: pdecr
    //                          - parametercategory : constant
    //                          - min : 0
    //                          - datatype : DOUBLE
    //                          - max : 10
    //                          - uri : some url
    //                          - default : 0.4
    //                          - inputtype : parameter
    //                          - unit : 
    //                          - description : Factor decreasing the phyllochron for leaf number less than Ldecr
    //            - name: pincr
    //                          - parametercategory : constant
    //                          - min : 0
    //                          - datatype : DOUBLE
    //                          - max : 10
    //                          - uri : some url
    //                          - default : 1.5
    //                          - inputtype : parameter
    //                          - unit : 
    //                          - description : Factor increasing the phyllochron for leaf number higher than Lincr
    //            - name: ptq
    //                          - parametercategory : species
    //                          - min : 0
    //                          - datatype : DOUBLE
    //                          - max : 10000
    //                          - uri : some url
    //                          - default : 0
    //                          - inputtype : variable
    //                          - unit : MJ °C-1 d-1 m-2)
    //                          - description : Photothermal quotient 
    //            - name: gai
    //                          - parametercategory : species
    //                          - min : 0
    //                          - datatype : DOUBLE
    //                          - max : 10000
    //                          - uri : some url
    //                          - default : 0
    //                          - inputtype : variable
    //                          - unit : m2 m-2
    //                          - description : Green Area Index
    //            - name: pastMaxAI
    //                          - min : 0
    //                          - default : 0
    //                          - max : 10000
    //                          - uri : some url
    //                          - variablecategory : state
    //                          - datatype : DOUBLE
    //                          - inputtype : variable
    //                          - unit : m2 m-2
    //                          - description : Past Maximum GAI
    //            - name: kl
    //                          - parametercategory : constant
    //                          - min : 0
    //                          - datatype : DOUBLE
    //                          - max : 50
    //                          - uri : some url
    //                          - default : 0.45
    //                          - inputtype : parameter
    //                          - unit : 
    //                          - description : Exctinction Coefficient
    //            - name: aPTQ
    //                          - parametercategory : constant
    //                          - min : 0
    //                          - datatype : DOUBLE
    //                          - max : 1000
    //                          - uri : some url
    //                          - default : 0.842934
    //                          - inputtype : variable
    //                          - unit : 
    //                          - description : Slope to intercept ratio for Phyllochron  parametrization with PhotoThermal Quotient
    //            - name: phylPTQ1
    //                          - parametercategory : constant
    //                          - min : 0
    //                          - datatype : DOUBLE
    //                          - max : 1000
    //                          - uri : some url
    //                          - default : 20
    //                          - inputtype : parameter
    //                          - unit : °C d leaf-1
    //                          - description : Phyllochron at PTQ equal 1
    //            - name: p
    //                          - parametercategory : species
    //                          - min : 0
    //                          - datatype : DOUBLE
    //                          - max : 1000
    //                          - uri : some url
    //                          - default : 120
    //                          - inputtype : parameter
    //                          - unit : °C d leaf-1
    //                          - description : Phyllochron (Varietal parameter)
    //            - name: choosePhyllUse
    //                          - default : Default
    //                          - datatype : STRING
    //                          - description : Switch to choose the type of phyllochron calculation to be used
    //                          - uri : some url
    //                          - unit : 
    //                          - inputtype : parameter
        //- outputs:
    //            - name: phyllochron
    //                          - datatype : DOUBLE
    //                          - min : 0
    //                          - variablecategory : state
    //                          - max : 1000
    //                          - unit :  °C d leaf-1
    //                          - description :  the rate of leaf appearance 
    //            - name: pastMaxAI
    //                          - datatype : DOUBLE
    //                          - min : 0
    //                          - variablecategory : auxiliary
    //                          - max : 10000
    //                          - unit : m2 m-2
    //                          - description : Past maximum GAI
        double phyllochron;
        double gai_;
        if (choosePhyllUse == "Default")
        {
            if (leafNumber < ldecr)
            {
                phyllochron = fixPhyll * pdecr;
            }
            else if ( leafNumber >= ldecr && leafNumber < lincr)
            {
                phyllochron = fixPhyll;
            }
            else
            {
                phyllochron = fixPhyll * pincr;
            }
        }
        if (choosePhyllUse == "PTQ")
        {
            gai_ = Math.Max(pastMaxAI, gai);
            pastMaxAI = gai_;
            if (gai_ > 0.0d)
            {
                phyllochron = phylPTQ1 * gai_ * kl / (1 - Math.Exp(-kl * gai_)) / (ptq + aPTQ);
            }
            else
            {
                phyllochron = phylPTQ1;
            }
        }
        if (choosePhyllUse == "Test")
        {
            if (leafNumber < ldecr)
            {
                phyllochron = p * pdecr;
            }
            else if ( leafNumber >= ldecr && leafNumber < lincr)
            {
                phyllochron = p;
            }
            else
            {
                phyllochron = p * pincr;
            }
        }
        return Tuple.Create(phyllochron, pastMaxAI);
    }
}