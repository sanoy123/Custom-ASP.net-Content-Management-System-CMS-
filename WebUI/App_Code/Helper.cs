using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;
using System.Collections.Specialized;


/// <summary>
/// Summary description for Helper
/// </summary>
public class Helper
{
    private static string[] _countries = new string[] { 
        "--- Select Country ---", "Afghanistan", "Albania", "Algeria", "American Samoa", "Andorra", 
         "Angola", "Anguilla", "Antarctica", "Antigua And Barbuda", "Argentina", 
         "Armenia", "Aruba", "Australia", "Austria", "Azerbaijan",
		   "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus",
		   "Belgium", "Belize", "Benin", "Bermuda", "Bhutan",
		   "Bolivia", "Bosnia Hercegovina", "Botswana", "Bouvet Island", "Brazil",
		   "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Burundi", "Byelorussian SSR",
		   "Cambodia", "Cameroon", "Canada", "Cape Verde", "Cayman Islands",
		   "Central African Republic", "Chad", "Chile", "China", "Christmas Island",
		   "Cocos (Keeling) Islands", "Colombia", "Comoros", "Congo", "Cook Islands",
		   "Costa Rica", "Cote D'Ivoire", "Croatia", "Cuba", "Cyprus",
		   "Czech Republic", "Czechoslovakia", "Denmark", "Djibouti", "Dominica",
		   "Dominican Republic", "East Timor", "Ecuador", "Egypt", "El Salvador",
		   "England", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia",
		   "Falkland Islands", "Faroe Islands", "Fiji", "Finland", "France",
		   "Gabon", "Gambia", "Georgia", "Germany", "Ghana",
		   "Gibraltar", "Great Britain", "Greece", "Greenland", "Grenada",
		   "Guadeloupe", "Guam", "Guatemela", "Guernsey", "Guiana",
		   "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Heard Islands",
		   "Honduras", "Hong Kong", "Hungary", "Iceland", "India",
		   "Indonesia", "Iran", "Iraq", "Ireland", "Isle Of Man",
		   "Israel", "Italy", "Jamaica", "Japan", "Jersey",
		   "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, South",
		   "Korea, North", "Kuwait", "Kyrgyzstan", "Lao People's Dem. Rep.", "Latvia",
		   "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein",
		   "Lithuania", "Luxembourg", "Macau", "Macedonia", "Madagascar",
		   "Malawi", "Malaysia", "Maldives", "Mali", "Malta",
		   "Mariana Islands", "Marshall Islands", "Martinique", "Mauritania", "Mauritius",
		   "Mayotte", "Mexico", "Micronesia", "Moldova", "Monaco",
		   "Mongolia", "Montserrat", "Morocco", "Mozambique", "Myanmar",
		   "Namibia", "Nauru", "Nepal", "Netherlands", "Netherlands Antilles",
		   "Neutral Zone", "New Caledonia", "New Zealand", "Nicaragua", "Niger",
		   "Nigeria", "Niue", "Norfolk Island", "Northern Ireland", "Norway",
		   "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea",
		   "Paraguay", "Peru", "Philippines", "Pitcairn", "Poland",
		   "Polynesia", "Portugal", "Puerto Rico", "Qatar", "Reunion",
		   "Romania", "Russian Federation", "Rwanda", "Saint Helena", "Saint Kitts",
		   "Saint Lucia", "Saint Pierre", "Saint Vincent", "Samoa", "San Marino",
		   "Sao Tome and Principe", "Saudi Arabia", "Scotland", "Senegal", "Seychelles",
		   "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands",
		   "Somalia", "South Africa", "South Georgia", "Spain", "Sri Lanka",
		   "Sudan", "Suriname", "Svalbard", "Swaziland", "Sweden",
		   "Switzerland", "Syrian Arab Republic", "Taiwan", "Tajikista", "Tanzania",
		   "Thailand", "Togo", "Tokelau", "Tonga", "Trinidad and Tobago",
		   "Tunisia", "Turkey", "Turkmenistan", "Turks and Caicos Islands", "Tuvalu",
		   "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States",
		   "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City State", "Venezuela",
		   "Vietnam", "Virgin Islands", "Wales", "Western Sahara", "Yemen",
		   "Yugoslavia", "Zaire", "Zambia", "Zimbabwe"};
    public Helper()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static string MonthName(int month)
    {
        if (month == 1)
            return "January";
        else if (month == 2)
            return "Febraury";
        else if (month == 3)
            return "March";
        else if (month == 4)
            return "April";
        else if (month == 5)
            return "May";
        else if (month == 6)
            return "June";
        else if (month == 7)
            return "July";
        else if (month == 8)
            return "August";
        else if (month == 9)
            return "September";
        else if (month == 10)
            return "October";
        else if (month == 11)
            return "November";
        else 
            return "December";




    }
    public static StringCollection GetCountries()
    {
       StringCollection countries = new StringCollection();
        countries.AddRange(_countries);
        return countries;
    }
   
   
   
}
