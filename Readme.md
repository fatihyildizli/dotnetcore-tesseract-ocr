[![GitHub stars](https://img.shields.io/github/stars/fatihyildizli/dotnetcore-tesseract-ocr.svg)](https://github.com/fatihyildizli/dotnetcore-tesseract-ocr/stargazers)
[![GitHub forks](https://img.shields.io/github/forks/fatihyildizli/dotnetcore-tesseract-ocr.svg)](https://github.com/fatihyildizli/dotnetcore-tesseract-ocr/network/members)
[![Total Downloads](https://img.shields.io/packagist/dt/fatihyildizli/dotnetcore-tesseract-ocr.svg?style=flat-square)](https://packagist.org/packages/fatihyildizli/dotnetcore-tesseract-ocr)
![License](https://img.shields.io/github/license/fatihyildizli/dotnetcore-tesseract-ocr)
![Code size](https://img.shields.io/github/repo-size/fatihyildizli/dotnetcore-tesseract-ocr)
![Top Language](https://img.shields.io/github/languages/top/fatihyildizli/dotnetcore-tesseract-ocr)
![Languages](https://img.shields.io/github/languages/count/fatihyildizli/dotnetcore-tesseract-ocr)
![Views](https://img.shields.io/github/search/fatihyildizli/dotnetcore-tesseract-ocr/dotnetcore-tesseract-ocr)


#### Brief:
This project (POC) consists of how to implement Tesseract OCR engine in dotnetcore.

Medium Link: https://medium.com/@fatih_yildizli/tesseract-ocr-implementation-in-net-core-spring-boot-6f876a5d4ae5

#### API Endpoint: localhost:2000/api/ocr

#### Example Usage 
Request **(Form-data)** : 

 **DestinationLanguage:** Nationality Prefix { TR,ENG,ARA ... }  
 
 **Image:** Select postman UI file type

![Alt](/wiki/sampleRequest.PNG "Sample")

**Tesseract Supported Language**
This project supports only english language. If you want different language, You must download traineddata from below list. 

#### Language List  
Lang Code | Language | 4.0 traineddata
:---------| :------- | :---------------
afr | Afrikaans | [afr.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/afr.traineddata)
amh | Amharic | [amh.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/amh.traineddata)
ara | Arabic | [ara.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/ara.traineddata)
asm | Assamese | [asm.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/asm.traineddata)
aze | Azerbaijani | [aze.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/aze.traineddata)
aze_cyrl | Azerbaijani - Cyrillic | [aze_cyrl.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/aze_cyrl.traineddata)
bel | Belarusian | [bel.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/bel.traineddata)
ben | Bengali | [ben.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/ben.traineddata)
bod | Tibetan | [bod.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/bod.traineddata)
bos | Bosnian | [bos.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/bos.traineddata)
bul | Bulgarian | [bul.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/bul.traineddata)
cat | Catalan; Valencian | [cat.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/cat.traineddata)
ceb | Cebuano | [ceb.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/ceb.traineddata)
ces | Czech | [ces.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/ces.traineddata)
chi_sim | Chinese - Simplified | [chi_sim.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/chi_sim.traineddata)
chi_tra | Chinese - Traditional | [chi_tra.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/chi_tra.traineddata)
chr | Cherokee | [chr.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/chr.traineddata)
cym | Welsh | [cym.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/cym.traineddata)
dan | Danish | [dan.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/dan.traineddata)
deu | German | [deu.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/deu.traineddata)
dzo | Dzongkha | [dzo.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/dzo.traineddata)
ell | Greek, Modern (1453-) | [ell.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/ell.traineddata)
eng | English | [eng.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/eng.traineddata)
enm | English, Middle (1100-1500) | [enm.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/enm.traineddata)
epo | Esperanto | [epo.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/epo.traineddata)
est | Estonian | [est.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/est.traineddata)
eus | Basque | [eus.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/eus.traineddata)
fas | Persian | [fas.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/fas.traineddata)
fin | Finnish | [fin.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/fin.traineddata)
fra | French | [fra.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/fra.traineddata)
frk | German Fraktur | [frk.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/frk.traineddata)
frm | French, Middle (ca. 1400-1600) | [frm.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/frm.traineddata)
gle | Irish | [gle.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/gle.traineddata)
glg | Galician | [glg.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/glg.traineddata)
grc | Greek, Ancient (-1453) | [grc.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/grc.traineddata)
guj | Gujarati | [guj.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/guj.traineddata)
hat | Haitian; Haitian Creole | [hat.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/hat.traineddata)
heb | Hebrew | [heb.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/heb.traineddata)
hin | Hindi | [hin.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/hin.traineddata)
hrv | Croatian | [hrv.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/hrv.traineddata)
hun | Hungarian | [hun.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/hun.traineddata)
iku | Inuktitut | [iku.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/iku.traineddata)
ind | Indonesian | [ind.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/ind.traineddata)
isl | Icelandic | [isl.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/isl.traineddata)
ita | Italian | [ita.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/ita.traineddata)
ita_old | Italian - Old | [ita_old.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/ita_old.traineddata)
jav | Javanese | [jav.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/jav.traineddata)
jpn | Japanese | [jpn.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/jpn.traineddata)
kan | Kannada | [kan.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/kan.traineddata)
kat | Georgian | [kat.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/kat.traineddata)
kat_old | Georgian - Old | [kat_old.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/kat_old.traineddata)
kaz | Kazakh | [kaz.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/kaz.traineddata)
khm | Central Khmer | [khm.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/khm.traineddata)
kir | Kirghiz; Kyrgyz | [kir.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/kir.traineddata)
kor | Korean | [kor.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/kor.traineddata)
kur | Kurdish | [kur.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/kur.traineddata)
lao | Lao | [lao.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/lao.traineddata)
lat | Latin | [lat.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/lat.traineddata)
lav | Latvian | [lav.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/lav.traineddata)
lit | Lithuanian | [lit.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/lit.traineddata)
mal | Malayalam | [mal.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/mal.traineddata)
mar | Marathi | [mar.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/mar.traineddata)
mkd | Macedonian | [mkd.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/mkd.traineddata)
mlt | Maltese | [mlt.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/mlt.traineddata)
msa | Malay | [msa.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/msa.traineddata)
mya | Burmese | [mya.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/mya.traineddata)
nep | Nepali | [nep.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/nep.traineddata)
nld | Dutch; Flemish | [nld.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/nld.traineddata)
nor | Norwegian | [nor.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/nor.traineddata)
ori | Oriya | [ori.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/ori.traineddata)
pan | Panjabi; Punjabi | [pan.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/pan.traineddata)
pol | Polish | [pol.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/pol.traineddata)
por | Portuguese | [por.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/por.traineddata)
pus | Pushto; Pashto | [pus.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/pus.traineddata)
ron | Romanian; Moldavian; Moldovan | [ron.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/ron.traineddata)
rus | Russian | [rus.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/rus.traineddata)
san | Sanskrit | [san.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/san.traineddata)
sin | Sinhala; Sinhalese | [sin.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/sin.traineddata)
slk | Slovak | [slk.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/slk.traineddata)
slv | Slovenian | [slv.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/slv.traineddata)
spa | Spanish; Castilian | [spa.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/spa.traineddata)
spa_old | Spanish; Castilian - Old | [spa_old.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/spa_old.traineddata)
sqi | Albanian | [sqi.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/sqi.traineddata)
srp | Serbian | [srp.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/srp.traineddata)
srp_latn | Serbian - Latin | [srp_latn.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/srp_latn.traineddata)
swa | Swahili | [swa.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/swa.traineddata)
swe | Swedish | [swe.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/swe.traineddata)
syr | Syriac | [syr.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/syr.traineddata)
tam | Tamil | [tam.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/tam.traineddata)
tel | Telugu | [tel.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/tel.traineddata)
tgk | Tajik | [tgk.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/tgk.traineddata)
tgl | Tagalog | [tgl.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/tgl.traineddata)
tha | Thai | [tha.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/tha.traineddata)
tir | Tigrinya | [tir.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/tir.traineddata)
tur | Turkish | [tur.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/tur.traineddata)
uig | Uighur; Uyghur | [uig.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/uig.traineddata)
ukr | Ukrainian | [ukr.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/ukr.traineddata)
urd | Urdu | [urd.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/urd.traineddata)
uzb | Uzbek | [uzb.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/uzb.traineddata)
uzb_cyrl | Uzbek - Cyrillic | [uzb_cyrl.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/uzb_cyrl.traineddata)
vie | Vietnamese | [vie.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/vie.traineddata)
yid | Yiddish | [yid.traineddata](https://github.com/tesseract-ocr/tessdata/raw/4.00/yid.traineddata)

#### Libraries: 
https://github.com/tesseract-ocr/tesseract 
https://github.com/tesseract-ocr/tessdata 

