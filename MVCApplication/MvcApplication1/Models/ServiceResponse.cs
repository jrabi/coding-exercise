using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class OfferInfo
    {
        public int siteID { get; set; }
        public string language { get; set; }
        public string currency { get; set; }
    }

    public class Persona
    {
        public string personaType { get; set; }
    }

    public class UserInfo
    {
        public Persona persona { get; set; }
    }

    public class OfferDateRange
    {
        public int[] travelStartDate { get; set; }
        public int[] travelEndDate { get; set; }
        public int lengthOfStay { get; set; }
    }

    public class Destination
    {
        public int regionID { get; set; }
        public int associatedMultiCityRegionId { get; set; }
        public string longName { get; set; }
        public string shortName { get; set; }
        public string country { get; set; }
        public string province { get; set; }
        public string city { get; set; }
        public string tla { get; set; }
        public string nonLocalizedCity { get; set; }
    }

    public class HotelInfo
    {
        public int hotelId { get; set; }
        public string hotelName { get; set; }
        public string localizedHotelName { get; set; }
        public string hotelDestination { get; set; }
        public int hotelDestinationRegionID { get; set; }
        public string hotelLongDestination { get; set; }
        public string hotelStreetAddress { get; set; }
        public string hotelCity { get; set; }
        public string hotelProvince { get; set; }
        public string hotelCountryCode { get; set; }
        public float hotelLatitude { get; set; }
        public float hotelLongitude { get; set; }
        public float hotelStarRating { get; set; }
        public float hotelGuestReviewRating { get; set; }
        public int hotelReviewTotal { get; set; }
        public string hotelImageUrl { get; set; }
        public bool isOfficialRating { get; set; }
    }

    public class HotelUrgencyInfo
    {
        public int airAttachRemainingTime { get; set; }
        public int numberOfPeopleViewing { get; set; }
        public int numberOfPeopleBooked { get; set; }
        public int numberOfRoomsLeft { get; set; }
        public long lastBookedTime { get; set; }
        public string almostSoldStatus { get; set; }
        public string link { get; set; }
        public bool airAttachEnabled { get; set; }
    }

    public class HotelPricingInfo
    {
        public decimal averagePriceValue { get; set; }
        public decimal totalPriceValue { get; set; }
        public decimal crossOutPriceValue { get; set; }
        public decimal originalPricePerNight { get; set; }
        public decimal percentSavings { get; set; }
        public bool rr { get; set; }
    }

    public class HotelUrls
    {
        public string hotelInfositeUrl { get; set; }
        public string hotelSearchResultUrl { get; set; }
    }

    public class HotelOffer
    {
        public OfferDateRange offerDateRange { get; set; }
        public Destination destination { get; set; }
        public HotelInfo hotelInfo { get; set; }
        public HotelUrgencyInfo hotelUrgencyInfo { get; set; }
        public HotelPricingInfo hotelPricingInfo { get; set; }
        public HotelUrls hotelUrls { get; set; }
    }

    public class Offers
    {
        public HotelOffer[] Hotel { get; set; }
    }

    public class ServiceResponse
    {
        public OfferInfo offerInfo { get; set; }
        public UserInfo userInfo { get; set; }
        public Offers offers { get; set; }
    }
}