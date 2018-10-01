using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace her_care.Pages
{
    public class IntakeModel : PageModel
    {
        public void OnGet()
        {

        }
    }
  


    
    public class Demographics
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public DateTime TodaysDate {get; set;}
        public DateTime DateOfBirth {get; set;}
        public string Phone {get; set;}
        public string EmailAddress {get; set;}
        public string AddressOne { get; set; }
         public string AddressTwo { get; set; }
         public string City { get; set; }
         public string State { get; set; }
         public string Zip { get; set; }
         public string EmergencyContactFirst {get; set;}
         public string EmergencyContactLast {get; set;}
         public string EmergencyContactPhone {get; set;}
         public string BranchOfService {get; set;}
         public DateTime EntryDate {get; set;}
         public DateTime DischargDate {get; set;}
         public string DischargeType {get; set;}
         public Boolean CombatVet {get; set;}
         public string DisabliityRating {get; set;}
         public Boolean ActiveDuty {get; set;} //were you or are you on active duty, reserves, or national guard
    }

    public class CurrentEmploymentStatus
    {
        public Boolean Employed {get; set;}
        public Boolean Student {get; set;}
        public Boolean SelfEmployed {get; set;}
        public Boolean Contractor {get; set;}
        public Boolean WorkStudy {get; set;}
        public Boolean Intern {get; set;}
        public Boolean Unemployed {get; set;}
        public string Other {get; set;}
    }

    public class Livingsituation
    {
        public Boolean OnStreet {get; set;}
        public Boolean SofaSurfing {get; set;}
        public Boolean Shelter {get; set;}
        public Boolean TransitionalHousing {get; set;}
        public Boolean GroupHome {get; set;}
        public Boolean Rental {get; set;}
        public Boolean OwnHome {get; set;}
        public string Other {get; set;}
    }
    
    public class Livingarrangments
    {
        public Boolean FriendsOrRelatives {get; set;}
        public Boolean Alone {get; set;}
        public Boolean Temporary {get; set;}
        public Boolean Permanent {get; set;}
    }

    public class ServiceNeeds
    {
        public Boolean BusinessResources {get; set;}
        public Boolean DayCare {get; set;}
        public Boolean Housing {get; set;}
        public Boolean Clothing {get; set;}
        public Boolean DisablilityClaim {get; set;}
        public Boolean Legal {get; set;}
        public Boolean Counseling {get; set;}
        public Boolean EducationalOrVocationalRehab {get; set;}
        public Boolean Utilities {get; set;}
        public Boolean Food {get; set;}
        public Boolean Employment {get; set;}
        public Boolean Tranportation {get; set;}
        public string Other {get; set;}
    }

    public class OfficeUseOnly
    {
        public Boolean Email {get; set;}
        public Boolean InPerson {get; set;}
        public Boolean Phone {get; set;}
        public string ActionNotes {get; set;}
        public string CompletedBy {get; set;}
        public DateTime DateCompleted {get; set;}
        public string FollowUpNotes {get; set;}
    }
    
}

