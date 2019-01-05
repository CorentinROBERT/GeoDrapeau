using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoDrapeau
{
    class TabDrapeau:List<Drapeau>
    {
        public TabDrapeau()
        {
            
        }
        public void chargerDonnee()
        {
            Drapeau afghanistan = new Drapeau("Afghanistan", 3, "Assets/flag/Afghanistan.png");
            Drapeau afriqueDuSud = new Drapeau("Afrique du Sud", 3, "Assets/flag/Afrique du Sud.png");
            Drapeau albanie = new Drapeau("Albanie", 2, "Assets/flag/Albanie.png");
            Drapeau algerie = new Drapeau("Algérie", 1, "Assets/flag/Algérie.png");
            Drapeau allemagne = new Drapeau("Allemagne", 1, "Assets/flag/Allemagne.png");
            Drapeau andorre = new Drapeau("Andorre", 1, "Assets/flag/Andorre.png");
            Drapeau angola = new Drapeau("Angola", 3, "Assets/flag/Angola.png");
            Drapeau antiguaEtBarbuda = new Drapeau("Antigua et Barbuda", 3, "Assets/flag/Antigua-et-Barbuda.png");
            Drapeau arabeSahraouieDemocratique = new Drapeau("Arabe Sahraouie Démocratique", 3, "Assets/flag/Arabe Sahraouie démocratique.png");
            Drapeau arabieSaoudite = new Drapeau("Arabie Saoudite", 2, "Assets/flag/Arabie Saoudite.png");

            Add(afghanistan);
            Add(afriqueDuSud);
            Add(albanie);
            Add(algerie);
            Add(allemagne);
            Add(andorre);
            Add(angola);
            Add(antiguaEtBarbuda);
            Add(arabeSahraouieDemocratique);
            Add(arabieSaoudite);


            Drapeau argentine = new Drapeau("Argentine", 1, "Assets/flag/Argentine.png");
            Drapeau armenie = new Drapeau("Arménie", 3, "Assets/flag/Arménie.png");
            Drapeau australie = new Drapeau("Australie", 1, "Assets/flag/Australie.png");
            Drapeau autriche = new Drapeau("Autriche", 2, "Assets/flag/Autriche.png");
            Drapeau azerbaidjan = new Drapeau("Azerbaïdjan", 3, "Assets/flag/Azerbaïdjan.png");
            Drapeau bahamas = new Drapeau("Bahamas", 3, "Assets/flag/Bahamas.png");
            Drapeau bahrein = new Drapeau("Bahreïn", 3, "Assets/flag/Bahreïn.png");
            Drapeau bangladesh = new Drapeau("Bangladesh", 2, "Assets/flag/Bangladesh.png");
            Drapeau barbade = new Drapeau("Barabade", 3, "Assets/flag/Barabade.png");
            Drapeau belgique = new Drapeau("Belgique", 1, "Assets/flag/Belgique.png");

            Add(argentine);
            Add(armenie);
            Add(australie);
            Add(autriche);
            Add(azerbaidjan);
            Add(bahamas);
            Add(bahrein);
            Add(bangladesh);
            Add(barbade);
            Add(belgique);

            Drapeau belize = new Drapeau("Belize", 3, "Assets/flag/Belize.png");
            Drapeau benin = new Drapeau("Bénin", 3, "Assets/flag/Bénin.png");
            Drapeau bhoutan = new Drapeau("Bhoutan", 3, "Assets/flag/Bhoutan.png");
            Drapeau bielorussie = new Drapeau("Biélorussie", 3, "Assets/flag/Biélorussie.png");
            Drapeau birmanie = new Drapeau("Birmanie", 3, "Assets/flag/Birmanie.png");
            Drapeau bolivie = new Drapeau("Bolivie", 3, "Assets/flag/Bolivie.png");
            Drapeau bosnieherzegovine = new Drapeau("Bosnie-Herzégovine", 3, "Assets/flag/Bosnie-Herzégovine.png");
            Drapeau botswana = new Drapeau("Botsawana", 3, "Assets/flag/Botsawana.png");
            Drapeau bresil = new Drapeau("Brésil", 1, "Assets/flag/Brésil.png");
            Drapeau brunei = new Drapeau("Brunei", 3, "Assets/flag/Brunei.png");

            Add(belize);
            Add(benin);
            Add(bhoutan);
            Add(bielorussie);
            Add(birmanie);
            Add(bolivie);
            Add(bosnieherzegovine);
            Add(botswana);
            Add(bresil);
            Add(brunei);

            Drapeau bulgarie = new Drapeau("Bulgarie", 3, "Assets/flag/Bulgarie.png");
            Drapeau burkinafaso = new Drapeau("Burkina Faso", 3, "Assets/flag/Burkina Faso.png");
            Drapeau burundi = new Drapeau("Burundi", 3, "Assets/flag/Burundi.png");
            Drapeau cambodge = new Drapeau("Cambodge", 3, "Assets/flag/Cambodge.png");
            Drapeau cameroun = new Drapeau("Cameroun", 1, "Assets/flag/Cameroun.png");
            Drapeau canada = new Drapeau("Canada", 1, "Assets/flag/Canada.png");
            Drapeau capvert = new Drapeau("Cap-Vert", 3, "Assets/flag/Cap-Vert.png");
            Drapeau centrafrique = new Drapeau("Centrafrique", 3, "Assets/flag/Centrafrique.png");
            Drapeau chili = new Drapeau("Chili", 2, "Assets/flag/Chili.png");
            Drapeau chine = new Drapeau("Chine", 2, "Assets/flag/Chine.png");

            Add(bulgarie);
            Add(burkinafaso);
            Add(burundi);
            Add(cambodge);
            Add(cameroun);
            Add(canada);
            Add(capvert);
            Add(centrafrique);
            Add(chili);
            Add(chine);

            Drapeau chypre = new Drapeau("Chypre", 3, "Assets/flag/Chypre.png");
            Drapeau colombie = new Drapeau("Colombie", 2, "Assets/flag/Colombie.png");
            Drapeau comores = new Drapeau("Comores", 3, "Assets/flag/Comores.png");
            Drapeau congoDEmocratique = new Drapeau("Congo Démocratique", 3, "Assets/flag/Congo Démocratique.png");
            Drapeau congo = new Drapeau("Congo", 2, "Assets/flag/Congo.png");
            Drapeau coreeDuNord = new Drapeau("Corée du Nord", 3, "Assets/flag/Corée du Nord.png");
            Drapeau coreeDuSud = new Drapeau("Corée du Sud", 2, "Assets/flag/Corée du Sud.png");
            Drapeau costaRica = new Drapeau("Costa Rica", 2, "Assets/flag/Costa Rica.png");
            Drapeau cotedIvoire = new Drapeau("Côte d'Ivoire", 2, "Assets/flag/Côte d'Ivoire.png");
            Drapeau croatie = new Drapeau("Croatie", 1, "Assets/flag/Croatie.png");

            Add(chypre);
            Add(colombie);
            Add(comores);
            Add(congoDEmocratique);
            Add(congo);
            Add(coreeDuNord);
            Add(coreeDuSud);
            Add(costaRica);
            Add(cotedIvoire);
            Add(croatie);

            Drapeau cuba = new Drapeau("Cuba", 2, "Assets/flag/Cuba.png");
            Drapeau danemark = new Drapeau("Danemark", 1, "Assets/flag/Danemark.png");
            Drapeau djibouti = new Drapeau("Djibouti", 3, "Assets/flag/Djibouti.png");
            Drapeau dominique = new Drapeau("Dominique", 3, "Assets/flag/Dominique.png");
            Drapeau egypte = new Drapeau("Egypte", 2, "Assets/flag/Egypte.png");
            Drapeau emiratArabeUnis = new Drapeau("Emirats Arabe Unis", 3, "Assets/flag/Emirats Arabe Unis.png");
            Drapeau equateur = new Drapeau("Equateur", 2, "Assets/flag/Equateur.png");
            Drapeau erythree = new Drapeau("Erythrée", 3, "Assets/flag/Erythrée.png");
            Drapeau espagne = new Drapeau("Espagne", 1, "Assets/flag/Espagne.png");
            Drapeau estonie = new Drapeau("Estonie", 3, "Assets/flag/Estonie.png");

            Add(cuba);
            Add(danemark);
            Add(djibouti);
            Add(dominique);
            Add(egypte);
            Add(emiratArabeUnis);
            Add(equateur);
            Add(erythree);
            Add(espagne);
            Add(estonie);

            Drapeau etatsUnis = new Drapeau("Etats-Unis", 1, "Assets/flag/Etats-Unis.png");
            Drapeau ethiopie = new Drapeau("Ethiopie", 3, "Assets/flag/Ethiopie.png");
            Drapeau fidji = new Drapeau("Fidji", 3, "Assets/flag/Fidji.png");
            Drapeau finlande = new Drapeau("Finlande", 1, "Assets/flag/Finlande.png");
            Drapeau france = new Drapeau("France", 1, "Assets/flag/France.png");
            Drapeau gabon = new Drapeau("Gabon", 2, "Assets/flag/Gabon.png");
            Drapeau gambie = new Drapeau("Gambie", 3, "Assets/flag/Gambie.png");
            Drapeau georgie = new Drapeau("Géorgie", 2, "Assets/flag/Géorgie.png");
            Drapeau ghana = new Drapeau("Ghana", 2, "Assets/flag/Ghana.png");
            Drapeau grandeBretagne = new Drapeau("Grande Bretagne", 1, "Assets/flag/Grande Bretagne.png");

            Add(etatsUnis);
            Add(ethiopie);
            Add(fidji);
            Add(finlande);
            Add(france);
            Add(gabon);
            Add(gambie);
            Add(georgie);
            Add(ghana);
            Add(grandeBretagne);

            Drapeau grece = new Drapeau("Grèce", 2, "Assets/flag/Grèce.png");
            Drapeau grenade = new Drapeau("Grenade", 3, "Assets/flag/Grenade.png");
            Drapeau guatemala = new Drapeau("Guatemala", 3, "Assets/flag/Guatemala.png");
            Drapeau guineeBissau = new Drapeau("Guinée-Bissau", 3, "Assets/flag/Guinée-Bissau.png");
            Drapeau guineeEquatoriale = new Drapeau("Guinée Equatoriale", 3, "Assets/flag/Guinée Equatoriale.png");
            Drapeau guinee = new Drapeau("Guinée", 3, "Assets/flag/Guinée.png");
            Drapeau guyana = new Drapeau("Guyana", 3, "Assets/flag/Guyana.png");
            Drapeau haiti = new Drapeau("Haïti", 3, "Assets/flag/Haïti.png");
            Drapeau honduras = new Drapeau("Honduras", 2, "Assets/flag/Honduras.png");
            Drapeau hongrie = new Drapeau("Hongrie", 3, "Assets/flag/Hongrie.png");

            Add(grece);
            Add(grenade);
            Add(guatemala);
            Add(guineeBissau);
            Add(guineeEquatoriale);
            Add(guinee);
            Add(guyana);
            Add(haiti);
            Add(honduras);
            Add(hongrie);

            Drapeau ilesMarshall = new Drapeau("Iles Marshall", 3, "Assets/flag/Iles Marshall.png");
            Drapeau inde = new Drapeau("Inde", 3, "Assets/flag/Inde.png");
            Drapeau indonesie = new Drapeau("Indonésie", 2, "Assets/flag/Indonésie.png");
            Drapeau irak = new Drapeau("Irak", 2, "Assets/flag/Irak.png");
            Drapeau iran = new Drapeau("Iran", 2, "Assets/flag/Iran.png");
            Drapeau irelande = new Drapeau("Irelande", 1, "Assets/flag/Irelande.png");
            Drapeau islande = new Drapeau("Islande", 1, "Assets/flag/Islande.png");
            Drapeau isreal = new Drapeau("Israël", 2, "Assets/flag/Israël.png");
            Drapeau italie = new Drapeau("Italie", 1, "Assets/flag/Italie.png");
            Drapeau jamaique = new Drapeau("Jamaïque", 1, "Assets/flag/Jamaïque.png");

            Add(ilesMarshall);
            Add(inde);
            Add(indonesie);
            Add(irak);
            Add(iran);
            Add(irelande);
            Add(islande);
            Add(isreal);
            Add(italie);
            Add(jamaique);

            Drapeau japon = new Drapeau("Japon", 1, "Assets/flag/Japon.png");
            Drapeau jordanie = new Drapeau("Jordanie", 2, "Assets/flag/Jordanie.png");
            Drapeau kazakhstan = new Drapeau("Kazakhstan", 2, "Assets/flag/Kazakhstan.png");
            Drapeau kenya = new Drapeau("Kenya", 2, "Assets/flag/Kenya.png");
            Drapeau kirghizistan = new Drapeau("Kirghizistan", 3, "Assets/flag/Kirghizistan.png");
            Drapeau kiribati = new Drapeau("Kiribati", 3, "Assets/flag/Kiribati.png");
            Drapeau kosovo = new Drapeau("Kosovo", 3, "Assets/flag/Kosovo.png");
            Drapeau koweit = new Drapeau("Koweït", 3, "Assets/flag/Koweït.png");
            Drapeau laos = new Drapeau("Laos", 3, "Assets/flag/Laos.png");
            Drapeau lesotho = new Drapeau("Lesotho", 3, "Assets/flag/Lesotho.png");

            Add(japon);
            Add(jordanie);
            Add(kazakhstan);
            Add(kenya);
            Add(kirghizistan);
            Add(kiribati);
            Add(kosovo);
            Add(koweit);
            Add(laos);
            Add(lesotho);

            Drapeau lettonie = new Drapeau("Lettonie", 3, "Assets/flag/Lettonie.png");
            Drapeau liban = new Drapeau("Liban", 2, "Assets/flag/Liban.png");
            Drapeau liberia = new Drapeau("Libéria", 3, "Assets/flag/Libéria.png");
            Drapeau libye = new Drapeau("Libye", 3, "Assets/flag/Libye.png");
            Drapeau liechtenstein = new Drapeau("Liechtenstein", 3, "Assets/flag/Liechtenstein.png");
            Drapeau lituanie = new Drapeau("Lituanie", 3, "Assets/flag/Lituanie.png");
            Drapeau luxembourg = new Drapeau("Luxembourg", 2, "Assets/flag/Luxembourg.png");
            Drapeau macedoine = new Drapeau("Macédoine", 2, "Assets/flag/Macédoine.png");
            Drapeau madagascar = new Drapeau("Madagascar", 2, "Assets/flag/Madagascar.png");
            Drapeau malaisie = new Drapeau("Malaisie", 3, "Assets/flag/Malaisie.png");

            Add(lettonie);
            Add(liban);
            Add(liberia);
            Add(libye);
            Add(liechtenstein);
            Add(lituanie);
            Add(luxembourg);
            Add(macedoine);
            Add(madagascar);
            Add(malaisie);

            Drapeau malawi = new Drapeau("Malawi", 3, "Assets/flag/Malawi.png");
            Drapeau maldives = new Drapeau("Maldives", 3, "Assets/flag/Maldives.png");
            Drapeau mali = new Drapeau("Mali", 2, "Assets/flag/Mali.png");
            Drapeau malte = new Drapeau("Malte", 2, "Assets/flag/Malte.png");
            Drapeau maroc = new Drapeau("Maroc", 1, "Assets/flag/Maroc.png");
            Drapeau maurice = new Drapeau("Maurice", 3, "Assets/flag/Maurice.png");
            Drapeau mauritanie = new Drapeau("Mauritanie", 2, "Assets/flag/Mauritanie.png");
            Drapeau mexique = new Drapeau("Mexique", 2, "Assets/flag/Mexique.png");
            Drapeau micronesie = new Drapeau("Micronésie", 3, "Assets/flag/Micronésie.png");
            Drapeau moldavie = new Drapeau("Moldavie", 3, "Assets/flag/Moldavie.png");

            Add(malawi);
            Add(maldives);
            Add(mali);
            Add(malte);
            Add(maroc);
            Add(maurice);
            Add(mauritanie);
            Add(mexique);
            Add(micronesie);
            Add(moldavie);

            Drapeau monaco = new Drapeau("Monaco", 1, "Assets/flag/Monaco.png");
            Drapeau mongolie = new Drapeau("Mongolie", 3, "Assets/flag/Mongolie.png");
            Drapeau montenegro = new Drapeau("Monténégro", 3, "Assets/flag/Monténégro.png");
            Drapeau mozambique = new Drapeau("Mozambique", 3, "Assets/flag/Mozambique.png");
            Drapeau namibie = new Drapeau("Namibie", 3, "Assets/flag/Namibie.png");
            Drapeau nauru = new Drapeau("Nauru", 3, "Assets/flag/Nauru.png");
            Drapeau nepal = new Drapeau("Népal", 3, "Assets/flag/Népal.png");
            Drapeau nicaragua = new Drapeau("Nicaragua", 3, "Assets/flag/Nicaragua.png");
            Drapeau niger = new Drapeau("Niger", 2, "Assets/flag/Niger.png");
            Drapeau nigeria = new Drapeau("Nigeria", 2, "Assets/flag/Nigeria.png");

            Add(monaco);
            Add(mongolie);
            Add(montenegro);
            Add(mozambique);
            Add(namibie);
            Add(nauru);
            Add(nepal);
            Add(nicaragua);
            Add(niger);
            Add(nigeria);

            Drapeau norvege = new Drapeau("Norvège", 1, "Assets/flag/Norvège.png");
            Drapeau nouvelle_zelande = new Drapeau("Nouvelle-Zélande", 1, "Assets/flag/Nouvelle-Zélande.png");
            Drapeau oman = new Drapeau("Oman", 3, "Assets/flag/Oman.png");
            Drapeau ouganda = new Drapeau("Ouganda", 3, "Assets/flag/Ouganda.png");
            Drapeau ouzbekistan = new Drapeau("Ouzbékistan", 3, "Assets/flag/Ouzbékistan.png");
            Drapeau pakistan = new Drapeau("Pakistan", 3, "Assets/flag/Pakistan.png");
            Drapeau palaos = new Drapeau("Palaos", 3, "Assets/flag/Palaos.png");
            Drapeau panama = new Drapeau("Panama", 3, "Assets/flag/Panama.png");
            Drapeau papouasie = new Drapeau("Papouasie-Nouvelle-Guinée", 3, "Assets/flag/Papouasie-Nouvelle-Guinée.png");
            Drapeau paraguay = new Drapeau("Paraguay", 1, "Assets/flag/Paraguay.png");

            Add(norvege);
            Add(nouvelle_zelande);
            Add(oman);
            Add(ouganda);
            Add(ouzbekistan);
            Add(pakistan);
            Add(palaos);
            Add(panama);
            Add(papouasie);
            Add(paraguay);

            Drapeau pays_bas = new Drapeau("Pays-Bas", 1, "Assets/flag/Pays-Bas.png");
            Drapeau perou = new Drapeau("Pérou", 2, "Assets/flag/Pérou.png");
            Drapeau philippines = new Drapeau("Philippines", 3, "Assets/flag/Philippines.png");
            Drapeau pologne = new Drapeau("Pologne", 1, "Assets/flag/Pologne.png");
            Drapeau portugal = new Drapeau("Portugal", 1, "Assets/flag/Portugal.png");
            Drapeau qatar = new Drapeau("Qatar", 2, "Assets/flag/Qatar.png");
            Drapeau republique_dominique = new Drapeau("République-Dominicaine", 3, "Assets/flag/République Dominicaine.png");
            Drapeau roumanie = new Drapeau("Roumanie", 2, "Assets/flag/Roumanie.png");
            Drapeau russie = new Drapeau("Russie", 1, "Assets/flag/Russie.png");
            Drapeau rwanda = new Drapeau("Rwanda", 3, "Assets/flag/Rwanda.png");

            Add(pays_bas);
            Add(perou);
            Add(philippines);
            Add(pologne);
            Add(portugal);
            Add(qatar);
            Add(republique_dominique);
            Add(roumanie);
            Add(russie);
            Add(rwanda);

            Drapeau saint_marin = new Drapeau("Saint-Marin", 3, "Assets/flag/Saint-Marin.png");
            Drapeau saint_christophe = new Drapeau("Saint Christophe et Niévès", 3, "Assets/flag/Saint Christophe et Niévès.png");
            Drapeau saint_vincent = new Drapeau("Saint Vincent et les Grenadines", 3, "Assets/flag/Saint Vincent et les Grenadines.png");
            Drapeau sainte_lucie = new Drapeau("Sainte Lucie", 3, "Assets/flag/Sainte Lucie.png");
            Drapeau salomon = new Drapeau("Salomon", 3, "Assets/flag/Salomon.png");
            Drapeau salvador = new Drapeau("Salvador", 3, "Assets/flag/Salvador.png");
            Drapeau samao = new Drapeau("Samao", 3, "Assets/flag/Samao.png");
            Drapeau sao_tome = new Drapeau("Sao Tomé-et-Principe", 3, "Assets/flag/Sao Tomé-et-Principe.png");
            Drapeau senegal = new Drapeau("Sénégal", 1, "Assets/flag/Sénégal.png");
            Drapeau serbie = new Drapeau("Serbie", 3, "Assets/flag/Serbie.png");

            Add(saint_marin);
            Add(saint_christophe);
            Add(saint_vincent);
            Add(sainte_lucie);
            Add(salomon);
            Add(salvador);
            Add(samao);
            Add(sao_tome);
            Add(senegal);
            Add(serbie);

            Drapeau seychelles = new Drapeau("Seychelles", 2, "Assets/flag/Seychelles.png");
            Drapeau sierra_leone = new Drapeau("Sierra Leone", 3, "Assets/flag/Sierra Leone.png");
            Drapeau singapour = new Drapeau("Singapour", 2, "Assets/flag/Singapour.png");
            Drapeau slovaquie = new Drapeau("Slovaquie", 3, "Assets/flag/Slovaquie.png");
            Drapeau slovenie = new Drapeau("Slovénie", 2, "Assets/flag/Slovénie.png");
            Drapeau somalie = new Drapeau("Somalie", 3, "Assets/flag/Somalie.png");
            Drapeau soudan = new Drapeau("Soudan", 3, "Assets/flag/Soudan.png");
            Drapeau sri_lanka = new Drapeau("Sri Lanka", 3, "Assets/flag/Sri Lanka.png");
            Drapeau suede = new Drapeau("Suède", 1, "Assets/flag/Suède.png");
            Drapeau suisse = new Drapeau("Suisse", 1, "Assets/flag/Suisse.png");

            Add(seychelles);
            Add(sierra_leone);
            Add(singapour);
            Add(slovaquie);
            Add(slovenie);
            Add(somalie);
            Add(soudan);
            Add(sri_lanka);
            Add(suede);
            Add(suisse);

            Drapeau suriname = new Drapeau("Suriname", 3, "Assets/flag/Suriname.png");
            Drapeau swaziland = new Drapeau("Swaziland", 3, "Assets/flag/Swaziland.png");
            Drapeau syrie = new Drapeau("Syrie", 2, "Assets/flag/Syrie.png");
            Drapeau tadjikistan = new Drapeau("Tadjikistan", 3, "Assets/flag/Tadjikistan.png");
            Drapeau taiwan = new Drapeau("Taiwan", 3, "Assets/flag/Taiwan.png");
            Drapeau tanzanie = new Drapeau("Tanzanie", 3, "Assets/flag/Tanzanie.png");
            Drapeau tchad = new Drapeau("Tchad", 2, "Assets/flag/Tchad.png");
            Drapeau tchecoslovaquie = new Drapeau("Tchécoslovaquie", 2, "Assets/flag/Tchécoslovaquie.png");
            Drapeau thailande = new Drapeau("Thaïlande", 3, "Assets/flag/Thaïlande.png");
            Drapeau timor = new Drapeau("Timor Oriental", 3, "Assets/flag/Timor Oriental.png");

            Add(suriname);
            Add(swaziland);
            Add(syrie);
            Add(tadjikistan);
            Add(taiwan);
            Add(tanzanie);
            Add(tchad);
            Add(tchecoslovaquie);
            Add(thailande);
            Add(timor);

            Drapeau togo = new Drapeau("Togo", 3, "Assets/flag/Togo.png");
            Drapeau tonga = new Drapeau("Tonga", 3, "Assets/flag/Tonga.png");
            Drapeau trinite = new Drapeau("Trinité-et-Tobago", 3, "Assets/flag/Trinité-et-Tobago.png");
            Drapeau tunisie = new Drapeau("Tunisie", 1, "Assets/flag/Tunisie.png");
            Drapeau turkmenistan = new Drapeau("Turkménistan", 3, "Assets/flag/Turkménistan.png");
            Drapeau turquie = new Drapeau("Turquie", 1, "Assets/flag/Turquie.png");
            Drapeau tuvalu = new Drapeau("Tuvalu", 3, "Assets/flag/Tuvalu.png");
            Drapeau ukraine = new Drapeau("Ukraine", 2, "Assets/flag/Ukraine.png");
            Drapeau uruguay = new Drapeau("Uruguay", 2, "Assets/flag/Uruguay.png");
            Drapeau vanuatu = new Drapeau("Vanuatu", 3, "Assets/flag/Vanuatu.png");

            Add(togo);
            Add(tonga);
            Add(trinite);
            Add(tunisie);
            Add(turkmenistan);
            Add(turquie);
            Add(tuvalu);
            Add(ukraine);
            Add(uruguay);
            Add(vanuatu);

            Drapeau vatican = new Drapeau("Vatican", 3, "Assets/flag/Vatican.png");
            Drapeau venezuela = new Drapeau("Venezuela", 3, "Assets/flag/Venezuela.png");
            Drapeau vietnam = new Drapeau("Viêt Nam", 2, "Assets/flag/Viêt Nam.png");
            Drapeau yemen = new Drapeau("Yemen", 3, "Assets/flag/Yemen.png");
            Drapeau zambie = new Drapeau("Zambie", 3, "Assets/flag/Zambie.png");
            Drapeau zimbabwe = new Drapeau("Zimbabwe", 3, "Assets/flag/Zimbabwe.png");

            Add(vatican);
            Add(venezuela);
            Add(vietnam);
            Add(yemen);
            Add(zambie);
            Add(zimbabwe);
        }
        public void chargerFacile(List<Drapeau> listDrapeaux)
        {
            foreach (Drapeau drap in this)
            {
                if(drap.Niveau == 1)
                {
                    listDrapeaux.Add(drap);
                }
            }
        }
        public void chargerMoyen(List<Drapeau> listDrapeaux)
        {
            foreach (Drapeau drap in this)
            {
                if (drap.Niveau == 2)
                {
                    listDrapeaux.Add(drap);
                }
            }
        }
        public void chargerDifficile(List<Drapeau> listDrapeaux)
        {
            foreach (Drapeau drap in this)
            {
                if (drap.Niveau == 3)
                {
                    listDrapeaux.Add(drap);
                }
            }
        }
        public Drapeau chercheDrapeauNom(string nom)
        {
            foreach (Drapeau tmp in this)
            {
                if (nom.Equals(tmp.Nom))
                {
                    return tmp;
                }
            }
            return new Drapeau("",0,"");
        }
    }
}
