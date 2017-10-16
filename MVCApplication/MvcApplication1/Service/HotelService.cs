using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Configuration;
using MvcApplication1.Models;

namespace MvcApplication1.Service
{
    public static class HotelService
    {
        private static string uri;

        static HotelService()
        {
            uri = ConfigurationManager.AppSettings["HotelServiceUrl"].ToString();
        }

        public static IList<HotelOffer> GetOffers(HotelSearch hotelSearch)
        {
            string requestUri = uri;
            if (!string.IsNullOrEmpty(hotelSearch.Destination))
                requestUri += "&destinationName=" + HttpUtility.UrlEncode(hotelSearch.Destination);
            if (!string.IsNullOrEmpty(hotelSearch.TripStartDateFrom))
                requestUri += "&minTripStartDate=" + HttpUtility.UrlEncode(hotelSearch.TripStartDateFrom);
            if (!string.IsNullOrEmpty(hotelSearch.TripStartDateTo))
                requestUri += "&maxTripStartDate=" + HttpUtility.UrlEncode(hotelSearch.TripStartDateTo);
            if (!string.IsNullOrEmpty(hotelSearch.StayLength))
                requestUri += "&lengthOfStay=" + HttpUtility.UrlEncode(hotelSearch.StayLength);
            if (!string.IsNullOrEmpty(hotelSearch.StarRatingFrom))
                requestUri += "&minStarRating=" + HttpUtility.UrlEncode(hotelSearch.StarRatingFrom);

            byte[] responseBytes = RequestWebService(requestUri);
            ServiceResponse serviceResponse = JsonDeserialize<ServiceResponse>(responseBytes);
            return serviceResponse.offers.Hotel;
        }

        private static byte[] RequestWebService(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.KeepAlive = false;
            request.Method = "GET";
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream responseStream = response.GetResponseStream();
                MemoryStream memoryStream = new MemoryStream();
                responseStream.CopyTo(memoryStream);
                responseStream.Close();
                byte[] responseBytes = memoryStream.ToArray();
                return responseBytes;
            }
        }

        private static T JsonDeserialize<T>(byte[] responseData)
        {
            MemoryStream memoryStream = new MemoryStream(responseData);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            T response = default(T);
            if (memoryStream.Length != 0)
                response = (T)serializer.ReadObject(memoryStream);
            return response;
        }
    }
}