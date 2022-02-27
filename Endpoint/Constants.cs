namespace myprayertimes.esolat.Endpoint;

public static class Constants
{
    public static Dictionary<ZoneCode, Zone> Zones => new Dictionary<ZoneCode, Zone>()
    {
      [ZoneCode.JHR01] = new Zone(ZoneCode.JHR01, "Pulau Aur dan Pulau Pemanggil "),
      [ZoneCode.JHR02] = new Zone(ZoneCode.JHR02, "Johor Bahru, Kota Tinggi, Mersing"),
      [ZoneCode.JHR03] = new Zone(ZoneCode.JHR03, "Kluang, Pontian"),
      [ZoneCode.JHR04] = new Zone(ZoneCode.JHR04, "Batu Pahat, Muar, Segamat, Gemas Johor"),
      [ZoneCode.KDH01] = new Zone(ZoneCode.KDH01, "Kota Setar, Kubang Pasu, Pokok Sena (Daerah Kecil)"),
      [ZoneCode.KDH02] = new Zone(ZoneCode.KDH02, "Kuala Muda, Yan, Pendang"),
      [ZoneCode.KDH03] = new Zone(ZoneCode.KDH03, "Padang Terap, Sik"),
      [ZoneCode.KDH04] = new Zone(ZoneCode.KDH04, "Baling"),
      [ZoneCode.KDH05] = new Zone(ZoneCode.KDH05, "Bandar Baharu, Kulim"),
      [ZoneCode.KDH06] = new Zone(ZoneCode.KDH06, "Langkawi"),
      [ZoneCode.KDH07] = new Zone(ZoneCode.KDH07, "Puncak Gunung Jerai"),
      [ZoneCode.KTN01] = new Zone(ZoneCode.KTN01, "Bachok, Kota Bharu, Machang, Pasir Mas, Pasir Puteh, Tanah Merah, Tumpat, Kuala Krai, Mukim Chiku"),
      [ZoneCode.KTN03] = new Zone(ZoneCode.KTN03, "Gua Musang (Daerah Galas Dan Bertam), Jeli, Jajahan Kecil Lojing"),
      [ZoneCode.MLK01] = new Zone(ZoneCode.MLK01, "SELURUH NEGERI MELAKA"),
      [ZoneCode.NGS01] = new Zone(ZoneCode.NGS01, "Tampin, Jempol"),
      [ZoneCode.NGS02] = new Zone(ZoneCode.NGS02, "Jelebu, Kuala Pilah, Port Dickson, Rembau, Seremban"),
      [ZoneCode.PHG01] = new Zone(ZoneCode.PHG01, "Pulau Tioman"),
      [ZoneCode.PHG02] = new Zone(ZoneCode.PHG02, "Kuantan, Pekan, Rompin, Muadzam Shah"),
      [ZoneCode.PHG03] = new Zone(ZoneCode.PHG03, "Jerantut, Temerloh, Maran, Bera, Chenor, Jengka"),
      [ZoneCode.PHG04] = new Zone(ZoneCode.PHG04, "Bentong, Lipis, Raub"),
      [ZoneCode.PHG05] = new Zone(ZoneCode.PHG05, "Genting Sempah, Janda Baik, Bukit Tinggi"),
      [ZoneCode.PHG06] = new Zone(ZoneCode.PHG06, "Cameron Highlands, Genting Higlands, Bukit Fraser"),
      [ZoneCode.PLS01] = new Zone(ZoneCode.PLS01, "Kangar, Padang Besar, Arau"),
      [ZoneCode.PNG01] = new Zone(ZoneCode.PNG01, "Seluruh Negeri Pulau Pinang"),
      [ZoneCode.PRK01] = new Zone(ZoneCode.PRK01, "Tapah, Slim River, Tanjung Malim"),
      [ZoneCode.PRK02] = new Zone(ZoneCode.PRK02, "Kuala Kangsar, Sg. Siput , Ipoh, Batu Gajah, Kampar"),
      [ZoneCode.PRK03] = new Zone(ZoneCode.PRK03, "Lenggong, Pengkalan Hulu, Grik"),
      [ZoneCode.PRK04] = new Zone(ZoneCode.PRK04, "Temengor, Belum"),
      [ZoneCode.PRK05] = new Zone(ZoneCode.PRK05, "Kg Gajah, Teluk Intan, Bagan Datuk, Seri Iskandar, Beruas, Parit, Lumut, Sitiawan, Pulau Pangkor"),
      [ZoneCode.PRK06] = new Zone(ZoneCode.PRK06, "Selama, Taiping, Bagan Serai, Parit Buntar"),
      [ZoneCode.PRK07] = new Zone(ZoneCode.PRK07, "Bukit Larut"),
      [ZoneCode.SBH01] = new Zone(ZoneCode.SBH01, "Bahagian Sandakan (Timur), Bukit Garam, Semawang, Temanggong, Tambisan, Bandar Sandakan, Sukau"),
      [ZoneCode.SBH02] = new Zone(ZoneCode.SBH02, "Beluran, Telupid, Pinangah, Terusan, Kuamut, Bahagian Sandakan (Barat)"),
      [ZoneCode.SBH03] = new Zone(ZoneCode.SBH03, "Lahad Datu, Silabukan, Kunak, Sahabat, Semporna, Tungku, Bahagian Tawau (Timur)"),
      [ZoneCode.SBH04] = new Zone(ZoneCode.SBH04, "Bandar Tawau, Balong, Merotai, Kalabakan, Bahagian Tawau (Barat)"),
      [ZoneCode.SBH05] = new Zone(ZoneCode.SBH05, "Kudat, Kota Marudu, Pitas, Pulau Banggi, Bahagian Kudat"),
      [ZoneCode.SBH06] = new Zone(ZoneCode.SBH06, "Gunung Kinabalu"),
      [ZoneCode.SBH07] = new Zone(ZoneCode.SBH07, "Kota Kinabalu, Ranau, Kota Belud, Tuaran, Penampang, Papar, Putatan, Bahagian Pantai Barat"),
      [ZoneCode.SBH08] = new Zone(ZoneCode.SBH08, "Pensiangan, Keningau, Tambunan, Nabawan, Bahagian Pendalaman (Atas)"),
      [ZoneCode.SBH09] = new Zone(ZoneCode.SBH09, "Beaufort, Kuala Penyu, Sipitang, Tenom, Long Pa Sia, Membakut, Weston, Bahagian Pendalaman (Bawah)"),
      [ZoneCode.SGR01] = new Zone(ZoneCode.SGR01, "Gombak, Petaling, Sepang, Hulu Langat, Hulu Selangor, S.Alam"),
      [ZoneCode.SGR02] = new Zone(ZoneCode.SGR02, "Kuala Selangor, Sabak Bernam"),
      [ZoneCode.SGR03] = new Zone(ZoneCode.SGR03, "Klang, Kuala Langat"),
      [ZoneCode.SWK01] = new Zone(ZoneCode.SWK01, "Limbang, Lawas, Sundar, Trusan"),
      [ZoneCode.SWK02] = new Zone(ZoneCode.SWK02, "Miri, Niah, Bekenu, Sibuti, Marudi"),
      [ZoneCode.SWK03] = new Zone(ZoneCode.SWK03, "Pandan, Belaga, Suai, Tatau, Sebauh, Bintulu"),
      [ZoneCode.SWK04] = new Zone(ZoneCode.SWK04, "Sibu, Mukah, Dalat, Song, Igan, Oya, Balingian, Kanowit, Kapit"),
      [ZoneCode.SWK05] = new Zone(ZoneCode.SWK05, "Sarikei, Matu, Julau, Rajang, Daro, Bintangor, Belawai"),
      [ZoneCode.SWK06] = new Zone(ZoneCode.SWK06, "Lubok Antu, Sri Aman, Roban, Debak, Kabong, Lingga, Engkelili, Betong, Spaoh, Pusa, Saratok"),
      [ZoneCode.SWK07] = new Zone(ZoneCode.SWK07, "Serian, Simunjan, Samarahan, Sebuyau, Meludam"),
      [ZoneCode.SWK08] = new Zone(ZoneCode.SWK08, "Kuching, Bau, Lundu, Sematan"),
      [ZoneCode.SWK09] = new Zone(ZoneCode.SWK09, "Zon Khas (Kampung Patarikan)"),
      [ZoneCode.TRG01] = new Zone(ZoneCode.TRG01, "Kuala Terengganu, Marang, Kuala Nerus"),
      [ZoneCode.TRG02] = new Zone(ZoneCode.TRG02, "Besut, Setiu"),
      [ZoneCode.TRG03] = new Zone(ZoneCode.TRG03, "Hulu Terengganu"),
      [ZoneCode.TRG04] = new Zone(ZoneCode.TRG04, "Dungun, Kemaman"),
      [ZoneCode.WLY01] = new Zone(ZoneCode.WLY01, "Kuala Lumpur, Putrajaya"),
      [ZoneCode.WLY02] = new Zone(ZoneCode.WLY02, "Labuan")
    };
    
    public static string BaseUrl(Protocol protocol, Period period, Zone zone)
        => $"{protocol.ToString().ToLower()}://www.e-solat.gov.my/index.php?r=esolatApi/takwimsolat&period={period.Name}&zone={zone.Code}";

    public static string DurationFormat => "yyyy-MM-dd";

    public static string UserAgent =>
        "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36";
}