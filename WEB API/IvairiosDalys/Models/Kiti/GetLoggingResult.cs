﻿namespace ApiMokymai.Models.Kiti
{
    public class GetLoggingResult
    {
        public GetLoggingResult(string message)
        {
            Message = message;
        }


        /// <summary>
        /// issaugoma kazkokia zinute
        /// </summary>
        /// 
        public string Message { get; set; }


    }





}