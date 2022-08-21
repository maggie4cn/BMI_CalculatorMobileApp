﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BMIServiceSOAP
{
    [ServiceContract]
    public interface IBMIService
    {

        [OperationContract]
        double myBMI(int height, int weight);

        [OperationContract]
        BMI myHealth(int height, int weight);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class BMI
    {
        [DataMember]
        public double bmi { get; set; }

        [DataMember]
        public string risk { get; set; }

        [DataMember]
        public String[] more { get; set; }
    }
}
