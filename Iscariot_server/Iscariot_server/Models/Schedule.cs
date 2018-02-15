using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Iscariot_server.Models
{
    public class Schedule
    {
        public Guid Id { get; set; }
        public string Faculty { get; set; }
        public string Specialty { get; set; }
        public string Section { get; set; }
        public int Term { get; set; }
        public string Monday_Ch { get; set; }
        public string Monday_Z      {get;set;}
        public string Tuesday_Ch    {get;set;}
        public string Tueday_Z      {get;set;}
        public string Wednesday_Ch  {get;set;}
        public string Wednesday_Z   {get;set;}
        public string Thursday_Ch   {get;set;}
        public string Thursday_Z    {get;set;}
        public string Friday_Ch     {get;set;}
        public string Friday_Z      {get;set;}
        public string Saturday_Ch   {get;set;}
        public string Saturday_Z    {get;set;}
        public string Sunday_Ch     {get;set;}  
        public string Sunday_Z      {get;set;}
    }
}