﻿using WebAppMSSQL.Models.DTO.ApiModels.kitas;

namespace WebAppMSSQL.Models.DTO.ApiModels
{

    public class CityLocation
    {
        public Geocoding geocoding { get; set; }
        public string type { get; set; }
        public Feature[] features { get; set; }
        public float[] bbox { get; set; }
    }

    public class Geocoding
    {
        public string version { get; set; }
        public string attribution { get; set; }
        public Query query { get; set; }
        public Engine engine { get; set; }
        public long timestamp { get; set; }
    }

    public class Query
    {
        public Parsed_Text parsed_text { get; set; }
        public int size { get; set; }
        public bool _private { get; set; }
        public Lang lang { get; set; }
        public int querySize { get; set; }
    }

    public class Parsed_Text
    {
        public string city { get; set; }
    }

    public class Lang
    {
        public string name { get; set; }
        public string iso6391 { get; set; }
        public string iso6393 { get; set; }
        public string via { get; set; }
        public bool defaulted { get; set; }
    }

    public class Engine
    {
        public string name { get; set; }
        public string author { get; set; }
        public string version { get; set; }
    }

    public class Feature
    {
        public string type { get; set; }
        public Geometry geometry { get; set; }
        public Properties properties { get; set; }
        public float[] bbox { get; set; }
    }

    public class Geometry
    {
        public string type { get; set; }
        public float[] coordinates { get; set; }
    }

    //public class Properties
    //{
    //    public string id { get; set; }
    //    public string gid { get; set; }
    //    public string layer { get; set; }
    //    public string source { get; set; }
    //    public string source_id { get; set; }
    //    public string name { get; set; }
    //    public int confidence { get; set; }
    //    public string match_type { get; set; }
    //    public string accuracy { get; set; }
    //    public string country { get; set; }
    //    public string country_gid { get; set; }
    //    public string country_a { get; set; }
    //    public string region { get; set; }
    //    public string region_gid { get; set; }
    //    public string region_a { get; set; }
    //    public string county { get; set; }
    //    public string county_gid { get; set; }
    //    public string locality { get; set; }
    //    public string locality_gid { get; set; }
    //    public string continent { get; set; }
    //    public string continent_gid { get; set; }
    //    public string label { get; set; }
    //    public Addendum addendum { get; set; }
    //    public string county_a { get; set; }
    //}

    public class Addendum
    {
        public Concordances concordances { get; set; }
        public Geonames geonames { get; set; }
    }

    public class Concordances
    {
        public int gnid { get; set; }
        public int gpid { get; set; }
        public int qs_pgid { get; set; }
        public string wdid { get; set; }
        public string wkpage { get; set; }
    }

    public class Geonames
    {
        public string feature_code { get; set; }
    }



    // 

    //public class Properties
    //{
    //    public Segment[] segments { get; set; }
    //    public Summary summary { get; set; }
    //    public int[] way_points { get; set; }
    //}


    //public class Summary
    //{
    //    public float distance { get; set; }
    //    public float duration { get; set; }
    //}


}
