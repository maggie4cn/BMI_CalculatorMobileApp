using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BMIServiceREST
{
    [ServiceContract]
    public interface IBMIService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/myBMI?height={height}&weight={weight}")] //defin input format
        double myBMI(int height, int weight);

        [OperationContract]
        [WebInvoke(Method = "GET",
         ResponseFormat = WebMessageFormat.Json, UriTemplate = "/myHealthJson?height={height}&weight={weight}")]
        BMI myHealthJson(int height, int weight);


        [OperationContract]
        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Xml, UriTemplate = "/myHealthXML?height={height}&weight={weight}")]
        BMI myHealthXML(int height, int weight);
    }

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
