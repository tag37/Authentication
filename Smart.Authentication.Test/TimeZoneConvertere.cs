﻿using System.Globalization;
using NUnit.Framework;

namespace Smart.Authentication.Test
{
    public class TimeZoneConvertere
    {
        /*
        [TestCase("Africa/Abidjan", "09:00:00","")]
        [TestCase("Africa/Accra", "09:00:00","")]
        [TestCase("Africa/Addis_Ababa", "09:00:00","")]
        [TestCase("Africa/Algiers", "09:00:00","")]
        [TestCase("Africa/Asmara", "09:00:00","")]
        [TestCase("Africa/Asmera", "09:00:00","")]
        [TestCase("Africa/Bamako", "09:00:00","")]
        [TestCase("Africa/Bangui", "09:00:00","")]
        [TestCase("Africa/Banjul", "09:00:00","")]
        [TestCase("Africa/Bissau", "09:00:00","")]
        [TestCase("Africa/Blantyre", "09:00:00","")]
        [TestCase("Africa/Brazzaville", "09:00:00","")]
        [TestCase("Africa/Bujumbura", "09:00:00","")]
        [TestCase("Africa/Cairo", "09:00:00","")]
        [TestCase("Africa/Casablanca", "09:00:00","")]
        [TestCase("Africa/Ceuta", "09:00:00","")]
        [TestCase("Africa/Conakry", "09:00:00","")]
        [TestCase("Africa/Dakar", "09:00:00","")]
        [TestCase("Africa/Dar_es_Salaam", "09:00:00","")]
        [TestCase("Africa/Djibouti", "09:00:00","")]
        [TestCase("Africa/Douala", "09:00:00","")]
        [TestCase("Africa/El_Aaiun", "09:00:00","")]
        [TestCase("Africa/Freetown", "09:00:00","")]
        [TestCase("Africa/Gaborone", "09:00:00","")]
        [TestCase("Africa/Harare", "09:00:00","")]
        [TestCase("Africa/Johannesburg", "09:00:00","")]
        [TestCase("Africa/Juba", "09:00:00","")]
        [TestCase("Africa/Kampala", "09:00:00","")]
        [TestCase("Africa/Khartoum", "09:00:00","")]
        [TestCase("Africa/Kigali", "09:00:00","")]
        [TestCase("Africa/Kinshasa", "09:00:00","")]
        [TestCase("Africa/Lagos", "09:00:00","")]
        [TestCase("Africa/Libreville", "09:00:00","")]
        [TestCase("Africa/Lome", "09:00:00","")]
        [TestCase("Africa/Luanda", "09:00:00","")]
        [TestCase("Africa/Lubumbashi", "09:00:00","")]
        [TestCase("Africa/Lusaka", "09:00:00","")]
        [TestCase("Africa/Malabo", "09:00:00","")]
        [TestCase("Africa/Maputo", "09:00:00","")]
        [TestCase("Africa/Maseru", "09:00:00","")]
        [TestCase("Africa/Mbabane", "09:00:00","")]
        [TestCase("Africa/Mogadishu", "09:00:00","")]
        [TestCase("Africa/Monrovia", "09:00:00","")]
        [TestCase("Africa/Nairobi", "09:00:00","")]
        [TestCase("Africa/Ndjamena", "09:00:00","")]
        [TestCase("Africa/Niamey", "09:00:00","")]
        [TestCase("Africa/Nouakchott", "09:00:00","")]
        [TestCase("Africa/Ouagadougou", "09:00:00","")]
        [TestCase("Africa/Porto-Novo", "09:00:00","")]
        [TestCase("Africa/Sao_Tome", "09:00:00","")]
        [TestCase("Africa/Timbuktu", "09:00:00","")]
        [TestCase("Africa/Tripoli", "09:00:00","")]
        [TestCase("Africa/Tunis", "09:00:00","")]
        [TestCase("Africa/Windhoek", "09:00:00","")]
        [TestCase("America/Adak", "09:00:00","")]
        [TestCase("America/Anchorage", "09:00:00","")]
        [TestCase("America/Anguilla", "09:00:00","")]
        [TestCase("America/Antigua", "09:00:00","")]
        [TestCase("America/Araguaina", "09:00:00","")]
        [TestCase("America/Argentina/Buenos_Aires", "09:00:00","")]
        [TestCase("America/Argentina/Catamarca", "09:00:00","")]
        [TestCase("America/Argentina/ComodRivadavia", "09:00:00","")]
        [TestCase("America/Argentina/Cordoba", "09:00:00","")]
        [TestCase("America/Argentina/Jujuy", "09:00:00","")]
        [TestCase("America/Argentina/La_Rioja", "09:00:00","")]
        [TestCase("America/Argentina/Mendoza", "09:00:00","")]
        [TestCase("America/Argentina/Rio_Gallegos", "09:00:00","")]
        [TestCase("America/Argentina/Salta", "09:00:00","")]
        [TestCase("America/Argentina/San_Juan", "09:00:00","")]
        [TestCase("America/Argentina/San_Luis", "09:00:00","")]
        [TestCase("America/Argentina/Tucuman", "09:00:00","")]
        [TestCase("America/Argentina/Ushuaia", "09:00:00","")]
        [TestCase("America/Aruba", "09:00:00","")]
        [TestCase("America/Asuncion", "09:00:00","")]
        [TestCase("America/Atikokan", "09:00:00","")]
        [TestCase("America/Atka", "09:00:00","")]
        [TestCase("America/Bahia", "09:00:00","")]
        [TestCase("America/Bahia_Banderas", "09:00:00","")]
        [TestCase("America/Barbados", "09:00:00","")]
        [TestCase("America/Belem", "09:00:00","")]
        [TestCase("America/Belize", "09:00:00","")]
        [TestCase("America/Blanc-Sablon", "09:00:00","")]
        [TestCase("America/Boa_Vista", "09:00:00","")]
        [TestCase("America/Bogota", "09:00:00","")]
        [TestCase("America/Boise", "09:00:00","")]
        [TestCase("America/Buenos_Aires", "09:00:00","")]
        [TestCase("America/Cambridge_Bay", "09:00:00","")]
        [TestCase("America/Campo_Grande", "09:00:00","")]
        [TestCase("America/Cancun", "09:00:00","")]
        [TestCase("America/Caracas", "09:00:00","")]
        [TestCase("America/Catamarca", "09:00:00","")]
        [TestCase("America/Cayenne", "09:00:00","")]
        [TestCase("America/Cayman", "09:00:00","")]
        [TestCase("America/Chicago", "09:00:00","")]
        [TestCase("America/Chihuahua", "09:00:00","")]
        [TestCase("America/Coral_Harbour", "09:00:00","")]
        [TestCase("America/Cordoba", "09:00:00","")]
        [TestCase("America/Costa_Rica", "09:00:00","")]

        [TestCase("America/Creston", "09:00:00","")]
        [TestCase("America/Cuiaba", "09:00:00","")]
        [TestCase("America/Curacao", "09:00:00","")]
        [TestCase("America/Danmarkshavn", "09:00:00","")]
        [TestCase("America/Dawson", "09:00:00","")]
        [TestCase("America/Dawson_Creek", "09:00:00","")]
        [TestCase("America/Denver", "09:00:00","")]
        [TestCase("America/Detroit", "09:00:00","")]
        [TestCase("America/Dominica", "09:00:00","")]
        [TestCase("America/Edmonton", "09:00:00","")]
        [TestCase("America/Eirunepe", "09:00:00","")]
        [TestCase("America/El_Salvador", "09:00:00","")]
        [TestCase("America/Ensenada", "09:00:00","")]
        [TestCase("America/Fort_Nelson", "09:00:00","")]
        [TestCase("America/Fort_Wayne", "09:00:00","")]
        [TestCase("America/Fortaleza", "09:00:00","")]
        [TestCase("America/Glace_Bay", "09:00:00","")]
        [TestCase("America/Godthab", "09:00:00","")]
        [TestCase("America/Goose_Bay", "09:00:00","")]
        [TestCase("America/Grand_Turk", "09:00:00","")]
        [TestCase("America/Grenada", "09:00:00","")]
        [TestCase("America/Guadeloupe", "09:00:00","")]
        [TestCase("America/Guatemala", "09:00:00","")]
        [TestCase("America/Guayaquil", "09:00:00","")]
        [TestCase("America/Guyana", "09:00:00","")]
        [TestCase("America/Halifax", "09:00:00","")]
        [TestCase("America/Havana", "09:00:00","")]
        [TestCase("America/Hermosillo", "09:00:00","")]
        [TestCase("America/Indiana/Indianapolis", "09:00:00","")]
        [TestCase("America/Indiana/Knox", "09:00:00","")]
        [TestCase("America/Indiana/Marengo", "09:00:00","")]
        [TestCase("America/Indiana/Petersburg", "09:00:00","")]
        [TestCase("America/Indiana/Tell_City", "09:00:00","")]
        [TestCase("America/Indiana/Vevay", "09:00:00","")]
        [TestCase("America/Indiana/Vincennes", "09:00:00","")]
        [TestCase("America/Indiana/Winamac", "09:00:00","")]
        [TestCase("America/Indianapolis", "09:00:00","")]
        [TestCase("America/Inuvik", "09:00:00","")]
        [TestCase("America/Iqaluit", "09:00:00","")]
        [TestCase("America/Jamaica", "09:00:00","")]
        [TestCase("America/Jujuy", "09:00:00","")]
        [TestCase("America/Juneau", "09:00:00","")]
        [TestCase("America/Kentucky/Louisville", "09:00:00","")]
        [TestCase("America/Kentucky/Monticello", "09:00:00","")]
        [TestCase("America/Knox_IN", "09:00:00","")]
        [TestCase("America/Kralendijk", "09:00:00","")]
        [TestCase("America/La_Paz", "09:00:00","")]
        [TestCase("America/Lima", "09:00:00","")]
        [TestCase("America/Los_Angeles", "09:00:00","")]
        [TestCase("America/Louisville", "09:00:00","")]
        [TestCase("America/Lower_Princes", "09:00:00","")]
        [TestCase("America/Maceio", "09:00:00","")]
        [TestCase("America/Managua", "09:00:00","")]
        [TestCase("America/Manaus", "09:00:00","")]
        [TestCase("America/Marigot", "09:00:00","")]
        [TestCase("America/Martinique", "09:00:00","")]
        [TestCase("America/Matamoros", "09:00:00","")]
        [TestCase("America/Mazatlan", "09:00:00","")]
        [TestCase("America/Mendoza", "09:00:00","")]
        [TestCase("America/Menominee", "09:00:00","")]
        [TestCase("America/Merida", "09:00:00","")]
        [TestCase("America/Metlakatla", "09:00:00","")]
        [TestCase("America/Mexico_City", "09:00:00","")]
        [TestCase("America/Miquelon", "09:00:00","")]
        [TestCase("America/Moncton", "09:00:00","")]
        [TestCase("America/Monterrey", "09:00:00","")]
        [TestCase("America/Montevideo", "09:00:00","")]
        [TestCase("America/Montreal", "09:00:00","")]
        [TestCase("America/Montserrat", "09:00:00","")]
        [TestCase("America/Nassau", "09:00:00","")]
        [TestCase("America/New_York", "09:00:00","")]
        [TestCase("America/Nipigon", "09:00:00","")]
        [TestCase("America/Nome", "09:00:00","")]
        [TestCase("America/Noronha", "09:00:00","")]
        [TestCase("America/North_Dakota/Beulah", "09:00:00","")]
        [TestCase("America/North_Dakota/Center", "09:00:00","")]
        [TestCase("America/North_Dakota/New_Salem", "09:00:00","")]
        [TestCase("America/Nuuk", "09:00:00","")]
        [TestCase("America/Ojinaga", "09:00:00","")]
        [TestCase("America/Panama", "09:00:00","")]
        [TestCase("America/Pangnirtung", "09:00:00","")]
        [TestCase("America/Paramaribo", "09:00:00","")]
        [TestCase("America/Phoenix", "09:00:00","")]
        [TestCase("America/Port-au-Prince", "09:00:00","")]
        [TestCase("America/Port_of_Spain", "09:00:00","")]
        [TestCase("America/Porto_Acre", "09:00:00","")]
        [TestCase("America/Porto_Velho", "09:00:00","")]
        [TestCase("America/Puerto_Rico", "09:00:00","")]
        [TestCase("America/Punta_Arenas", "09:00:00","")]
        [TestCase("America/Rainy_River", "09:00:00","")]
        [TestCase("America/Rankin_Inlet", "09:00:00","")]
        [TestCase("America/Recife", "09:00:00","")]
        [TestCase("America/Regina", "09:00:00","")]
        [TestCase("America/Resolute", "09:00:00","")]
        [TestCase("America/Rio_Branco", "09:00:00","")]
        [TestCase("America/Rosario", "09:00:00","")]
        [TestCase("America/Santa_Isabel", "09:00:00","")]
        [TestCase("America/Santarem", "09:00:00","")]
        [TestCase("America/Santiago", "09:00:00","")]
        [TestCase("America/Santo_Domingo", "09:00:00","")]
        [TestCase("America/Sao_Paulo", "09:00:00","")]
        [TestCase("America/Scoresbysund", "09:00:00","")]
        [TestCase("America/Shiprock", "09:00:00","")]
        [TestCase("America/Sitka", "09:00:00","")]
        [TestCase("America/St_Barthelemy", "09:00:00","")]
        [TestCase("America/St_Johns", "09:00:00","")]
        [TestCase("America/St_Kitts", "09:00:00","")]
        [TestCase("America/St_Lucia", "09:00:00","")]
        [TestCase("America/St_Thomas", "09:00:00","")]
        [TestCase("America/St_Vincent", "09:00:00","")]
        [TestCase("America/Swift_Current", "09:00:00","")]
        [TestCase("America/Tegucigalpa", "09:00:00","")]
        [TestCase("America/Thule", "09:00:00","")]
        [TestCase("America/Thunder_Bay", "09:00:00","")]
        [TestCase("America/Tijuana", "09:00:00","")]
        [TestCase("America/Toronto", "09:00:00","")]
        [TestCase("America/Tortola", "09:00:00","")]
        [TestCase("America/Vancouver", "09:00:00","")]
        [TestCase("America/Virgin", "09:00:00","")]
        [TestCase("America/Whitehorse", "09:00:00","")]
        [TestCase("America/Winnipeg", "09:00:00","")]
        [TestCase("America/Yakutat", "09:00:00","")]
        [TestCase("America/Yellowknife", "09:00:00","")]
        [TestCase("Antarctica/Casey", "09:00:00","")]
        [TestCase("Antarctica/Davis", "09:00:00","")]
        [TestCase("Antarctica/DumontDUrville", "09:00:00","")]
        [TestCase("Antarctica/Macquarie", "09:00:00","")]
        [TestCase("Antarctica/Mawson", "09:00:00","")]
        [TestCase("Antarctica/McMurdo", "09:00:00","")]
        [TestCase("Antarctica/Palmer", "09:00:00","")]
        [TestCase("Antarctica/Rothera", "09:00:00","")]
        [TestCase("Antarctica/South_Pole", "09:00:00","")]
        [TestCase("Antarctica/Syowa", "09:00:00","")]

        [TestCase("Antarctica/Vostok", "09:00:00","")]
        [TestCase("Arctic/Longyearbyen", "09:00:00","")]
        [TestCase("Asia/Aden", "09:00:00","")]
        [TestCase("Asia/Almaty", "09:00:00","")]
        [TestCase("Asia/Amman", "09:00:00","")]
        [TestCase("Asia/Anadyr", "09:00:00","")]
        [TestCase("Asia/Aqtau", "09:00:00","")]
        [TestCase("Asia/Aqtobe", "09:00:00","")]
        [TestCase("Asia/Ashgabat", "09:00:00","")]
        [TestCase("Asia/Ashkhabad", "09:00:00","")]
        [TestCase("Asia/Atyrau", "09:00:00","")]
        [TestCase("Asia/Baghdad", "09:00:00","")]
        [TestCase("Asia/Bahrain", "09:00:00","")]
        [TestCase("Asia/Baku", "09:00:00","")]
        [TestCase("Asia/Bangkok", "09:00:00","")]
        [TestCase("Asia/Barnaul", "09:00:00","")]
        [TestCase("Asia/Beirut", "09:00:00","")]
        [TestCase("Asia/Bishkek", "09:00:00","")]
        [TestCase("Asia/Brunei", "09:00:00","")]
        [TestCase("Asia/Calcutta", "09:00:00","")]
        [TestCase("Asia/Chita", "09:00:00","")]
        [TestCase("Asia/Choibalsan", "09:00:00","")]
        [TestCase("Asia/Chongqing", "09:00:00","")]
        [TestCase("Asia/Chungking", "09:00:00","")]
        [TestCase("Asia/Colombo", "09:00:00","")]
        [TestCase("Asia/Dacca", "09:00:00","")]
        [TestCase("Asia/Damascus", "09:00:00","")]
        [TestCase("Asia/Dhaka", "09:00:00","")]
        [TestCase("Asia/Dili", "09:00:00","")]
        [TestCase("Asia/Dubai", "09:00:00","")]
        [TestCase("Asia/Dushanbe", "09:00:00","")]
        [TestCase("Asia/Famagusta", "09:00:00","")]
        [TestCase("Asia/Gaza", "09:00:00","")]
        [TestCase("Asia/Harbin", "09:00:00","")]
        [TestCase("Asia/Hebron", "09:00:00","")]
        [TestCase("Asia/Ho_Chi_Minh", "09:00:00","")]
        [TestCase("Asia/Hong_Kong", "09:00:00","")]
        [TestCase("Asia/Hovd", "09:00:00","")]
        [TestCase("Asia/Irkutsk", "09:00:00","")]
        [TestCase("Asia/Istanbul", "09:00:00","")]
        [TestCase("Asia/Jakarta", "09:00:00","")]
        [TestCase("Asia/Jayapura", "09:00:00","")]
        [TestCase("Asia/Jerusalem", "09:00:00","")]
        [TestCase("Asia/Kabul", "09:00:00","")]
        [TestCase("Asia/Kamchatka", "09:00:00","")]
        [TestCase("Asia/Karachi", "09:00:00","")]

        [TestCase("Asia/Kathmandu", "09:00:00","")]
        [TestCase("Asia/Katmandu", "09:00:00","")]
        [TestCase("Asia/Khandyga", "09:00:00","")]
        [TestCase("Asia/Kolkata", "09:00:00","")]
        [TestCase("Asia/Krasnoyarsk", "09:00:00","")]
        [TestCase("Asia/Kuala_Lumpur", "09:00:00","")]
        [TestCase("Asia/Kuching", "09:00:00","")]
        [TestCase("Asia/Kuwait", "09:00:00","")]
        [TestCase("Asia/Macao", "09:00:00","")]
        [TestCase("Asia/Macau", "09:00:00","")]
        [TestCase("Asia/Magadan", "09:00:00","")]
        [TestCase("Asia/Makassar", "09:00:00","")]
        [TestCase("Asia/Manila", "09:00:00","")]
        [TestCase("Asia/Muscat", "09:00:00","")]
        [TestCase("Asia/Nicosia", "09:00:00","")]
        [TestCase("Asia/Novokuznetsk", "09:00:00","")]
        [TestCase("Asia/Novosibirsk", "09:00:00","")]
        [TestCase("Asia/Omsk", "09:00:00","")]
        [TestCase("Asia/Oral", "09:00:00","")]
        [TestCase("Asia/Phnom_Penh", "09:00:00","")]
        [TestCase("Asia/Pontianak", "09:00:00","")]
        [TestCase("Asia/Pyongyang", "09:00:00","")]
        [TestCase("Asia/Qatar", "09:00:00","")]
        [TestCase("Asia/Qostanay", "09:00:00","")]
        [TestCase("Asia/Qyzylorda", "09:00:00","")]
        [TestCase("Asia/Rangoon", "09:00:00","")]
        [TestCase("Asia/Riyadh", "09:00:00","")]
        [TestCase("Asia/Saigon", "09:00:00","")]
        [TestCase("Asia/Sakhalin", "09:00:00","")]
        [TestCase("Asia/Samarkand", "09:00:00","")]
        [TestCase("Asia/Seoul", "09:00:00","")]
        [TestCase("Asia/Shanghai", "09:00:00","")]
        [TestCase("Asia/Singapore", "09:00:00","")]
        [TestCase("Asia/Srednekolymsk", "09:00:00","")]
        [TestCase("Asia/Taipei", "09:00:00","")]
        [TestCase("Asia/Tashkent", "09:00:00","")]
        [TestCase("Asia/Tbilisi", "09:00:00","")]
        [TestCase("Asia/Tehran", "09:00:00","")]
        [TestCase("Asia/Tel_Aviv", "09:00:00","")]
        [TestCase("Asia/Thimbu", "09:00:00","")]
        [TestCase("Asia/Thimphu", "09:00:00","")]
        [TestCase("Asia/Tokyo", "09:00:00","")]
        [TestCase("Asia/Tomsk", "09:00:00","")]
        [TestCase("Asia/Ujung_Pandang", "09:00:00","")]
        [TestCase("Asia/Ulaanbaatar", "09:00:00","")]
        [TestCase("Asia/Ulan_Bator", "09:00:00","")]

        [TestCase("Asia/Ust-Nera", "09:00:00","")]
        [TestCase("Asia/Vientiane", "09:00:00","")]
        [TestCase("Asia/Vladivostok", "09:00:00","")]
        [TestCase("Asia/Yakutsk", "09:00:00","")]
        [TestCase("Asia/Yangon", "09:00:00","")]
        [TestCase("Asia/Yekaterinburg", "09:00:00","")]
        [TestCase("Asia/Yerevan", "09:00:00","")]
        [TestCase("Atlantic/Azores", "09:00:00","")]
        [TestCase("Atlantic/Bermuda", "09:00:00","")]
        [TestCase("Atlantic/Canary", "09:00:00","")]
        [TestCase("Atlantic/Cape_Verde", "09:00:00","")]
        [TestCase("Atlantic/Faeroe", "09:00:00","")]
        [TestCase("Atlantic/Faroe", "09:00:00","")]
        [TestCase("Atlantic/Jan_Mayen", "09:00:00","")]
        [TestCase("Atlantic/Madeira", "09:00:00","")]
        [TestCase("Atlantic/Reykjavik", "09:00:00","")]
        [TestCase("Atlantic/South_Georgia", "09:00:00","")]
        [TestCase("Atlantic/St_Helena", "09:00:00","")]
        [TestCase("Atlantic/Stanley", "09:00:00","")]
        [TestCase("Australia/ACT", "09:00:00","")]
        [TestCase("Australia/Adelaide", "09:00:00","")]
        [TestCase("Australia/Brisbane", "09:00:00","")]
        [TestCase("Australia/Broken_Hill", "09:00:00","")]
        [TestCase("Australia/Canberra", "09:00:00","")]
        [TestCase("Australia/Currie", "09:00:00","")]
        [TestCase("Australia/Darwin", "09:00:00","")]
        [TestCase("Australia/Eucla", "09:00:00","")]
        [TestCase("Australia/Hobart", "09:00:00","")]
        [TestCase("Australia/LHI", "09:00:00","")]
        [TestCase("Australia/Lindeman", "09:00:00","")]
        [TestCase("Australia/Lord_Howe", "09:00:00","")]
        [TestCase("Australia/Melbourne", "09:00:00","")]
        [TestCase("Australia/North", "09:00:00","")]
        [TestCase("Australia/NSW", "09:00:00","")]
        [TestCase("Australia/Perth", "09:00:00","")]
        [TestCase("Australia/Queensland", "09:00:00","")]
        [TestCase("Australia/South", "09:00:00","")]
        [TestCase("Australia/Sydney", "09:00:00","")]
        [TestCase("Australia/Tasmania", "09:00:00","")]
        [TestCase("Australia/Victoria", "09:00:00","")]
        [TestCase("Australia/West", "09:00:00","")]
        [TestCase("Australia/Yancowinna", "09:00:00","")]
        [TestCase("Brazil/Acre", "09:00:00","")]
        [TestCase("Brazil/DeNoronha", "09:00:00","")]
        [TestCase("Brazil/East", "09:00:00","")]
        [TestCase("Brazil/West", "09:00:00","")]
        [TestCase("Canada/Atlantic", "09:00:00","")]
        [TestCase("Canada/Central", "09:00:00","")]
        [TestCase("Canada/Eastern", "09:00:00","")]
        [TestCase("Canada/Mountain", "09:00:00","")]
        [TestCase("Canada/Newfoundland", "09:00:00","")]
        [TestCase("Canada/Pacific", "09:00:00","")]
        [TestCase("Canada/Saskatchewan", "09:00:00","")]
        [TestCase("Canada/Yukon", "09:00:00","")]
        [TestCase("Europe/Amsterdam", "09:00:00","")]
        [TestCase("Europe/Andorra", "09:00:00","")]
        [TestCase("Europe/Astrakhan", "09:00:00","")]
        [TestCase("Europe/Athens", "09:00:00","")]
        [TestCase("Europe/Belfast", "09:00:00","")]
        [TestCase("Europe/Belgrade", "09:00:00","")]
        [TestCase("Europe/Berlin", "09:00:00","")]
        [TestCase("Europe/Bratislava", "09:00:00","")]
        [TestCase("Europe/Brussels", "09:00:00","")]
        [TestCase("Europe/Bucharest", "09:00:00","")]
        [TestCase("Europe/Budapest", "09:00:00","")]
        [TestCase("Europe/Busingen", "09:00:00","")]
        [TestCase("Europe/Chisinau", "09:00:00","")]
        [TestCase("Europe/Copenhagen", "09:00:00","")]
        [TestCase("Europe/Dublin", "09:00:00","")]
        [TestCase("Europe/Gibraltar", "09:00:00","")]
        [TestCase("Europe/Guernsey", "09:00:00","")]
        [TestCase("Europe/Helsinki", "09:00:00","")]
        [TestCase("Europe/Isle_of_Man", "09:00:00","")]
        [TestCase("Europe/Istanbul", "09:00:00","")]
        [TestCase("Europe/Jersey", "09:00:00","")]
        [TestCase("Europe/Kaliningrad", "09:00:00","")]
        [TestCase("Europe/Kiev", "09:00:00","")]
        [TestCase("Europe/Kirov", "09:00:00","")]

        [TestCase("Europe/Lisbon", "09:00:00","")]
        [TestCase("Europe/Ljubljana", "09:00:00","")]
        [TestCase("Europe/London", "09:00:00","")]
        [TestCase("Europe/Luxembourg", "09:00:00","")]
        [TestCase("Europe/Madrid", "09:00:00","")]
        [TestCase("Europe/Malta", "09:00:00","")]
        [TestCase("Europe/Mariehamn", "09:00:00","")]
        [TestCase("Europe/Minsk", "09:00:00","")]
        [TestCase("Europe/Monaco", "09:00:00","")]
        [TestCase("Europe/Moscow", "09:00:00","")]
        [TestCase("Europe/Nicosia", "09:00:00","")]
        [TestCase("Europe/Oslo", "09:00:00","")]
        [TestCase("Europe/Paris", "09:00:00","")]
        [TestCase("Europe/Podgorica", "09:00:00","")]
        [TestCase("Europe/Prague", "09:00:00","")]
        [TestCase("Europe/Riga", "09:00:00","")]
        [TestCase("Europe/Rome", "09:00:00","")]
        [TestCase("Europe/Samara", "09:00:00","")]
        [TestCase("Europe/San_Marino", "09:00:00","")]
        [TestCase("Europe/Sarajevo", "09:00:00","")]
        [TestCase("Europe/Saratov", "09:00:00","")]
        [TestCase("Europe/Simferopol", "09:00:00","")]
        [TestCase("Europe/Skopje", "09:00:00","")]
        [TestCase("Europe/Sofia", "09:00:00","")]
        [TestCase("Europe/Stockholm", "09:00:00","")]
        [TestCase("Europe/Tallinn", "09:00:00","")]
        [TestCase("Europe/Tirane", "09:00:00","")]
        [TestCase("Europe/Tiraspol", "09:00:00","")]
        [TestCase("Europe/Ulyanovsk", "09:00:00","")]
        [TestCase("Europe/Uzhgorod", "09:00:00","")]
        [TestCase("Europe/Vaduz", "09:00:00","")]
        [TestCase("Europe/Vatican", "09:00:00","")]
        [TestCase("Europe/Vienna", "09:00:00","")]
        [TestCase("Europe/Vilnius", "09:00:00","")]
        [TestCase("Europe/Volgograd", "09:00:00","")]
        [TestCase("Europe/Warsaw", "09:00:00","")]
        [TestCase("Europe/Zagreb", "09:00:00","")]
        [TestCase("Europe/Zaporozhye", "09:00:00","")]
        [TestCase("Europe/Zurich", "09:00:00","")]
        [TestCase("Indian/Antananarivo", "09:00:00","")]
        [TestCase("Indian/Chagos", "09:00:00","")]
        [TestCase("Indian/Christmas", "09:00:00","")]
        [TestCase("Indian/Cocos", "09:00:00","")]
        [TestCase("Indian/Comoro", "09:00:00","")]
        [TestCase("Indian/Kerguelen", "09:00:00","")]
        [TestCase("Indian/Mahe", "09:00:00","")]
        [TestCase("Indian/Maldives", "09:00:00","")]
        [TestCase("Indian/Mauritius", "09:00:00","")]
        [TestCase("Indian/Mayotte", "09:00:00","")]
        [TestCase("Indian/Reunion", "09:00:00","")]
        [TestCase("Mexico/BajaNorte", "09:00:00","")]
        [TestCase("Mexico/BajaSur", "09:00:00","")]
        [TestCase("Mexico/General", "09:00:00","")]
        [TestCase("Pacific/Apia", "09:00:00","")]
        [TestCase("Pacific/Auckland", "09:00:00","")]
        [TestCase("Pacific/Bougainville", "09:00:00","")]
        [TestCase("Pacific/Chatham", "09:00:00","")]
        [TestCase("Pacific/Chuuk", "09:00:00","")]
        [TestCase("Pacific/Easter", "09:00:00","")]
        [TestCase("Pacific/Efate", "09:00:00","")]
        [TestCase("Pacific/Enderbury", "09:00:00","")]
        [TestCase("Pacific/Fakaofo", "09:00:00","")]
        [TestCase("Pacific/Fiji", "09:00:00","")]
        [TestCase("Pacific/Funafuti", "09:00:00","")]
        [TestCase("Pacific/Galapagos", "09:00:00","")]
        [TestCase("Pacific/Gambier", "09:00:00","")]
        [TestCase("Pacific/Guadalcanal", "09:00:00","")]
        [TestCase("Pacific/Guam", "09:00:00","")]
        [TestCase("Pacific/Honolulu", "09:00:00","")]
        [TestCase("Pacific/Johnston", "09:00:00","")]

        [TestCase("Pacific/Kiritimati", "09:00:00","")]
        [TestCase("Pacific/Kosrae", "09:00:00","")]
        [TestCase("Pacific/Kwajalein", "09:00:00","")]
        [TestCase("Pacific/Majuro", "09:00:00","")]
        [TestCase("Pacific/Marquesas", "09:00:00","")]
        [TestCase("Pacific/Midway", "09:00:00","")]
        [TestCase("Pacific/Nauru", "09:00:00","")]
        [TestCase("Pacific/Niue", "09:00:00","")]
        [TestCase("Pacific/Norfolk", "09:00:00","")]
        [TestCase("Pacific/Noumea", "09:00:00","")]
        [TestCase("Pacific/Pago_Pago", "09:00:00","")]
        [TestCase("Pacific/Palau", "09:00:00","")]
        [TestCase("Pacific/Pitcairn", "09:00:00","")]
        [TestCase("Pacific/Pohnpei", "09:00:00","")]
        [TestCase("Pacific/Ponape", "09:00:00","")]
        [TestCase("Pacific/Port_Moresby", "09:00:00","")]
        [TestCase("Pacific/Rarotonga", "09:00:00","")]
        [TestCase("Pacific/Saipan", "09:00:00","")]
        [TestCase("Pacific/Samoa", "09:00:00","")]
        [TestCase("Pacific/Tahiti", "09:00:00","")]
        [TestCase("Pacific/Tarawa", "09:00:00","")]
        [TestCase("Pacific/Tongatapu", "09:00:00","")]
        [TestCase("Pacific/Truk", "09:00:00","")]
        [TestCase("Pacific/Wake", "09:00:00","")]
        [TestCase("Pacific/Wallis", "09:00:00","")]
        [TestCase("Pacific/Yap", "09:00:00","")]
        [TestCase("US/Alaska", "09:00:00","")]
        [TestCase("US/Aleutian", "09:00:00","")]
        [TestCase("US/Arizona", "09:00:00","")]
        [TestCase("US/Central", "09:00:00","")]
        [TestCase("US/East-Indiana", "09:00:00","")]
        [TestCase("US/Eastern", "09:00:00","")]*/

        [TestCase("US/Hawaii", "09:00:00", "")]
        [TestCase("US/Indiana-Starke", "09:00:00", "")]
        [TestCase("US/Michigan", "09:00:00", "")]
        [TestCase("US/Mountain", "09:00:00", "")]
        [TestCase("US/Pacific", "09:00:00", "")]
        [TestCase("US/Samoa", "09:00:00", "")]


        [TestCase("Pacific/Kanton", "09:00:00", "")]
        [TestCase("Europe/Kyiv", "09:00:00", "")]
        [TestCase("Asia/Urumqi", "09:00:00", "")]
        [TestCase("Asia/Kashgar", "09:00:00", "")]
        [TestCase("Antarctica/Troll", "09:00:00", "")]
        [TestCase("America/Coyhaique", "09:00:00", "")]
        [TestCase("America/Ciudad_Juarez", "09:00:00", "")]
        public void TimeZoneConverter(string timeZoneId, string time, string result)
        {
            DateTime today = DateTime.Today;

            TimeSpan parsedTime = TimeSpan.ParseExact(time, "hh\\:mm\\:ss", CultureInfo.InvariantCulture);
            DateTime combined = today.Add(parsedTime);

            DateTime localTimeUnspecified = DateTime.SpecifyKind(combined, DateTimeKind.Unspecified);
            TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
            DateTime utcTime = TimeZoneInfo.ConvertTimeToUtc(localTimeUnspecified, timeZoneInfo);

            string timeUtc = utcTime.ToString("HH:mm:ss");
            Console.WriteLine($"UTC Time: {timeUtc}");
        }
    }
}
