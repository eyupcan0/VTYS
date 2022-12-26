PGDMP     $    9                z            TrenTakipSistemi    15.1    15.1 h    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16624    TrenTakipSistemi    DATABASE     �   CREATE DATABASE "TrenTakipSistemi" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Turkish_Turkey.utf8';
 "   DROP DATABASE "TrenTakipSistemi";
                postgres    false            �            1255    16625    bilethesap(integer, integer)    FUNCTION     �   CREATE FUNCTION public.bilethesap(duraksayi integer, tarifefiyat integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
declare 
	fiyat integer;
begin
fiyat=durakSayi*tarifeFiyat;
return fiyat;
end;
$$;
 I   DROP FUNCTION public.bilethesap(duraksayi integer, tarifefiyat integer);
       public          postgres    false            �            1255    16626    deleteengelliyolcusayisi()    FUNCTION     �   CREATE FUNCTION public.deleteengelliyolcusayisi() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
	begin
	delete from engelliyolcukapasite where engelliyolcukapasite.engelliyolcusayi>=8;
return new;
end;
$$;
 1   DROP FUNCTION public.deleteengelliyolcusayisi();
       public          postgres    false            �            1255    16627    deleteyolcusayisi()    FUNCTION     �   CREATE FUNCTION public.deleteyolcusayisi() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
	begin
	delete from yolcukapasite where yolcukapasite.yolcusayi>=60;
return new;
end;
$$;
 *   DROP FUNCTION public.deleteyolcusayisi();
       public          postgres    false            �            1255    16628    durakhesap(integer, integer)    FUNCTION     �   CREATE FUNCTION public.durakhesap(d1 integer, d2 integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
declare 
	durakSayi integer;
begin
durakSayi=abs(d2-d1);
return durakSayi;
end;
$$;
 9   DROP FUNCTION public.durakhesap(d1 integer, d2 integer);
       public          postgres    false            �            1255    16629    engelliyolcusayisi()    FUNCTION     �   CREATE FUNCTION public.engelliyolcusayisi() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
	begin
	update engelliyolcukapasite set engelliyolcusayi=engelliyolcusayi+6;
return new;
end;
$$;
 +   DROP FUNCTION public.engelliyolcusayisi();
       public          postgres    false            �            1255    16630    kalangun(date)    FUNCTION     �   CREATE FUNCTION public.kalangun(sefertarih date) RETURNS integer
    LANGUAGE plpgsql
    AS $$
declare 
	kalanSure integer;
	simdikiTarih date;
begin
simdikiTarih=current_date;
kalanSure=seferTarih-simdikiTarih;
return kalanSure;
end;
$$;
 0   DROP FUNCTION public.kalangun(sefertarih date);
       public          postgres    false            �            1255    16631    unvanbirim(text, text)    FUNCTION     �   CREATE FUNCTION public.unvanbirim(unvan text, birimad text) RETURNS text
    LANGUAGE plpgsql
    AS $$
declare 
    unvanBirim1 text;
begin

    unvanBirim1='unvan'+'birimAd';
return unvanBirim1;
end;
$$;
 ;   DROP FUNCTION public.unvanbirim(unvan text, birimad text);
       public          postgres    false            �            1255    16632    yolcusayisi()    FUNCTION     �   CREATE FUNCTION public.yolcusayisi() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
	begin
	update yolcukapasite set yolcusayi=yolcusayi+10;
return new;
end;
$$;
 $   DROP FUNCTION public.yolcusayisi();
       public          postgres    false            �            1259    16633    musteri    TABLE     $  CREATE TABLE public.musteri (
    musteriid integer NOT NULL,
    trenid integer NOT NULL,
    musteriad character varying(30),
    musterisoyad character varying(30),
    mustericinsiyet character varying(30),
    musteritel character varying(20),
    musterieposta character varying(30)
);
    DROP TABLE public.musteri;
       public         heap    postgres    false            �            1259    16636    bireyselmusteri    TABLE     �   CREATE TABLE public.bireyselmusteri (
    musteriid integer,
    bireyselmusteriid integer NOT NULL,
    bireyselmusteritcn integer NOT NULL
)
INHERITS (public.musteri);
 #   DROP TABLE public.bireyselmusteri;
       public         heap    postgres    false    214            �            1259    16639 &   Bireysel Musteri_bireyselMusteriID_seq    SEQUENCE     �   ALTER TABLE public.bireyselmusteri ALTER COLUMN bireyselmusteriid ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Bireysel Musteri_bireyselMusteriID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    215            �            1259    16640    personel    TABLE     m  CREATE TABLE public.personel (
    personelid integer NOT NULL,
    personelad character varying(30),
    personelsoyad character varying(30),
    personelcinsiyet character varying(30),
    personeldogumtarih date,
    personeldogumyeri character varying(30),
    personelbirimadi text,
    personelunvan text,
    personelmaas integer,
    personeltel integer
);
    DROP TABLE public.personel;
       public         heap    postgres    false            �            1259    16645    idaripersonel    TABLE        CREATE TABLE public.idaripersonel (
    personelid integer,
    idaripersonelid integer NOT NULL
)
INHERITS (public.personel);
 !   DROP TABLE public.idaripersonel;
       public         heap    postgres    false    217            �            1259    16650 "   Idari Personel_idariPersonelID_seq    SEQUENCE     �   ALTER TABLE public.idaripersonel ALTER COLUMN idaripersonelid ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Idari Personel_idariPersonelID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    218            �            1259    16651    sirketpersonel    TABLE     �   CREATE TABLE public.sirketpersonel (
    personelid integer,
    sirketpersonelid integer NOT NULL
)
INHERITS (public.personel);
 "   DROP TABLE public.sirketpersonel;
       public         heap    postgres    false    217            �            1259    16656 $   Sirket Personel_sirketPersonelID_seq    SEQUENCE     �   ALTER TABLE public.sirketpersonel ALTER COLUMN sirketpersonelid ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Sirket Personel_sirketPersonelID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    220            �            1259    16657    vip    TABLE     �   CREATE TABLE public.vip (
    musteriid integer,
    vipmusteriid integer NOT NULL,
    vipmusteritcn integer NOT NULL
)
INHERITS (public.musteri);
    DROP TABLE public.vip;
       public         heap    postgres    false    214            �            1259    16660    VIP_VIPMusteriID_seq    SEQUENCE     �   ALTER TABLE public.vip ALTER COLUMN vipmusteriid ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."VIP_VIPMusteriID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    222            �            1259    16661    tren    TABLE     �   CREATE TABLE public.tren (
    trenid integer NOT NULL,
    hareketid integer NOT NULL,
    trenmarka character varying(30),
    ureticifirma character varying(30),
    trentur character varying(10),
    vagonadet integer
);
    DROP TABLE public.tren;
       public         heap    postgres    false            �            1259    16664    anahat    TABLE     i   CREATE TABLE public.anahat (
    trenid integer,
    anahatid integer NOT NULL
)
INHERITS (public.tren);
    DROP TABLE public.anahat;
       public         heap    postgres    false    224            �            1259    16667    bilet    TABLE       CREATE TABLE public.bilet (
    biletid integer NOT NULL,
    tarifeid integer NOT NULL,
    musteriid integer,
    hareketid integer NOT NULL,
    subeid integer NOT NULL,
    vagonid integer NOT NULL,
    bilettur character varying(30),
    sefertarih date
);
    DROP TABLE public.bilet;
       public         heap    postgres    false            �            1259    16670    engelliyolcukapasite    TABLE     K   CREATE TABLE public.engelliyolcukapasite (
    engelliyolcusayi integer
);
 (   DROP TABLE public.engelliyolcukapasite;
       public         heap    postgres    false            �            1259    16673    hareket    TABLE     �   CREATE TABLE public.hareket (
    hareketid integer NOT NULL,
    hareketsuresi character varying(20),
    hareketsaati character varying(20)
);
    DROP TABLE public.hareket;
       public         heap    postgres    false            �            1259    16676    hareketistasyonu    TABLE     �   CREATE TABLE public.hareketistasyonu (
    hareketistasyonid integer NOT NULL,
    hareketid integer NOT NULL,
    istasyonid integer NOT NULL
);
 $   DROP TABLE public.hareketistasyonu;
       public         heap    postgres    false            �            1259    16679    satisnoktalari    TABLE     �   CREATE TABLE public.satisnoktalari (
    subeid integer NOT NULL,
    subeil character varying(30),
    subeilce character varying(30)
);
 "   DROP TABLE public.satisnoktalari;
       public         heap    postgres    false            �            1259    16682    silinenyolcusayisi    TABLE     `   CREATE TABLE public.silinenyolcusayisi (
    silinenyolcu integer,
    silinentrenid integer
);
 &   DROP TABLE public.silinenyolcusayisi;
       public         heap    postgres    false            �            1259    16685    tarifebilgileri    TABLE     �   CREATE TABLE public.tarifebilgileri (
    tarifeid integer NOT NULL,
    tarifefiyat integer,
    tarifecesit character varying(30)
);
 #   DROP TABLE public.tarifebilgileri;
       public         heap    postgres    false            �            1259    16688    trenpersoneli    TABLE     �   CREATE TABLE public.trenpersoneli (
    trenpersonelid integer NOT NULL,
    personelid integer NOT NULL,
    trenid integer NOT NULL
);
 !   DROP TABLE public.trenpersoneli;
       public         heap    postgres    false            �            1259    16691    yht    TABLE     c   CREATE TABLE public.yht (
    trenid integer,
    yhtid integer NOT NULL
)
INHERITS (public.tren);
    DROP TABLE public.yht;
       public         heap    postgres    false    224            �            1259    16694    yolcukapasite    TABLE     =   CREATE TABLE public.yolcukapasite (
    yolcusayi integer
);
 !   DROP TABLE public.yolcukapasite;
       public         heap    postgres    false            �            1259    16697 	   İstasyon    TABLE     �   CREATE TABLE public."İstasyon" (
    istasyonid integer NOT NULL,
    istasyonil character varying(30),
    istasyonilce character varying(30),
    istasyonturu character varying(30)
);
    DROP TABLE public."İstasyon";
       public         heap    postgres    false            �            1259    16700    İstasyon_istasyonID_seq    SEQUENCE     �   ALTER TABLE public."İstasyon" ALTER COLUMN istasyonid ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."İstasyon_istasyonID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    236            �          0    16664    anahat 
   TABLE DATA           j   COPY public.anahat (trenid, hareketid, trenmarka, ureticifirma, trentur, vagonadet, anahatid) FROM stdin;
    public          postgres    false    225   x�       �          0    16667    bilet 
   TABLE DATA           o   COPY public.bilet (biletid, tarifeid, musteriid, hareketid, subeid, vagonid, bilettur, sefertarih) FROM stdin;
    public          postgres    false    226   ��       �          0    16636    bireyselmusteri 
   TABLE DATA           �   COPY public.bireyselmusteri (musteriid, trenid, musteriad, musterisoyad, mustericinsiyet, musteritel, musterieposta, bireyselmusteriid, bireyselmusteritcn) FROM stdin;
    public          postgres    false    215   $�       �          0    16670    engelliyolcukapasite 
   TABLE DATA           @   COPY public.engelliyolcukapasite (engelliyolcusayi) FROM stdin;
    public          postgres    false    227   A�       �          0    16673    hareket 
   TABLE DATA           I   COPY public.hareket (hareketid, hareketsuresi, hareketsaati) FROM stdin;
    public          postgres    false    228   b�       �          0    16676    hareketistasyonu 
   TABLE DATA           T   COPY public.hareketistasyonu (hareketistasyonid, hareketid, istasyonid) FROM stdin;
    public          postgres    false    229   ��       �          0    16645    idaripersonel 
   TABLE DATA           �   COPY public.idaripersonel (personelid, personelad, personelsoyad, personelcinsiyet, personeldogumtarih, personeldogumyeri, personelbirimadi, personelunvan, personelmaas, personeltel, idaripersonelid) FROM stdin;
    public          postgres    false    218   Ƃ       �          0    16633    musteri 
   TABLE DATA           y   COPY public.musteri (musteriid, trenid, musteriad, musterisoyad, mustericinsiyet, musteritel, musterieposta) FROM stdin;
    public          postgres    false    214   �       �          0    16640    personel 
   TABLE DATA           �   COPY public.personel (personelid, personelad, personelsoyad, personelcinsiyet, personeldogumtarih, personeldogumyeri, personelbirimadi, personelunvan, personelmaas, personeltel) FROM stdin;
    public          postgres    false    217   ʃ       �          0    16679    satisnoktalari 
   TABLE DATA           B   COPY public.satisnoktalari (subeid, subeil, subeilce) FROM stdin;
    public          postgres    false    230   ��       �          0    16682    silinenyolcusayisi 
   TABLE DATA           I   COPY public.silinenyolcusayisi (silinenyolcu, silinentrenid) FROM stdin;
    public          postgres    false    231   �       �          0    16651    sirketpersonel 
   TABLE DATA           �   COPY public.sirketpersonel (personelid, personelad, personelsoyad, personelcinsiyet, personeldogumtarih, personeldogumyeri, personelbirimadi, personelunvan, personelmaas, personeltel, sirketpersonelid) FROM stdin;
    public          postgres    false    220   0�       �          0    16685    tarifebilgileri 
   TABLE DATA           M   COPY public.tarifebilgileri (tarifeid, tarifefiyat, tarifecesit) FROM stdin;
    public          postgres    false    232   ��       �          0    16661    tren 
   TABLE DATA           ^   COPY public.tren (trenid, hareketid, trenmarka, ureticifirma, trentur, vagonadet) FROM stdin;
    public          postgres    false    224   �       �          0    16688    trenpersoneli 
   TABLE DATA           K   COPY public.trenpersoneli (trenpersonelid, personelid, trenid) FROM stdin;
    public          postgres    false    233   f�       �          0    16657    vip 
   TABLE DATA           �   COPY public.vip (musteriid, trenid, musteriad, musterisoyad, mustericinsiyet, musteritel, musterieposta, vipmusteriid, vipmusteritcn) FROM stdin;
    public          postgres    false    222   ��       �          0    16691    yht 
   TABLE DATA           d   COPY public.yht (trenid, hareketid, trenmarka, ureticifirma, trentur, vagonadet, yhtid) FROM stdin;
    public          postgres    false    234   ��       �          0    16694    yolcukapasite 
   TABLE DATA           2   COPY public.yolcukapasite (yolcusayi) FROM stdin;
    public          postgres    false    235   ��       �          0    16697 	   İstasyon 
   TABLE DATA           Y   COPY public."İstasyon" (istasyonid, istasyonil, istasyonilce, istasyonturu) FROM stdin;
    public          postgres    false    236   �       �           0    0 &   Bireysel Musteri_bireyselMusteriID_seq    SEQUENCE SET     W   SELECT pg_catalog.setval('public."Bireysel Musteri_bireyselMusteriID_seq"', 1, false);
          public          postgres    false    216            �           0    0 "   Idari Personel_idariPersonelID_seq    SEQUENCE SET     S   SELECT pg_catalog.setval('public."Idari Personel_idariPersonelID_seq"', 1, false);
          public          postgres    false    219            �           0    0 $   Sirket Personel_sirketPersonelID_seq    SEQUENCE SET     T   SELECT pg_catalog.setval('public."Sirket Personel_sirketPersonelID_seq"', 1, true);
          public          postgres    false    221            �           0    0    VIP_VIPMusteriID_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public."VIP_VIPMusteriID_seq"', 1, true);
          public          postgres    false    223            �           0    0    İstasyon_istasyonID_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public."İstasyon_istasyonID_seq"', 5, true);
          public          postgres    false    237            �           2606    16702    anahat AnaHat_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.anahat
    ADD CONSTRAINT "AnaHat_pkey" PRIMARY KEY (anahatid, trenid);
 >   ALTER TABLE ONLY public.anahat DROP CONSTRAINT "AnaHat_pkey";
       public            postgres    false    225    225            �           2606    16704    bilet Bilet_pkey 
   CONSTRAINT     U   ALTER TABLE ONLY public.bilet
    ADD CONSTRAINT "Bilet_pkey" PRIMARY KEY (biletid);
 <   ALTER TABLE ONLY public.bilet DROP CONSTRAINT "Bilet_pkey";
       public            postgres    false    226            �           2606    16706 %   bireyselmusteri Bireysel Musteri_pkey 
   CONSTRAINT        ALTER TABLE ONLY public.bireyselmusteri
    ADD CONSTRAINT "Bireysel Musteri_pkey" PRIMARY KEY (bireyselmusteriid, musteriid);
 Q   ALTER TABLE ONLY public.bireyselmusteri DROP CONSTRAINT "Bireysel Musteri_pkey";
       public            postgres    false    215    215            �           2606    16708 (   hareketistasyonu Hareket İstasyonu_pkey 
   CONSTRAINT     w   ALTER TABLE ONLY public.hareketistasyonu
    ADD CONSTRAINT "Hareket İstasyonu_pkey" PRIMARY KEY (hareketistasyonid);
 T   ALTER TABLE ONLY public.hareketistasyonu DROP CONSTRAINT "Hareket İstasyonu_pkey";
       public            postgres    false    229            �           2606    16710    hareket Hareket_pkey 
   CONSTRAINT     [   ALTER TABLE ONLY public.hareket
    ADD CONSTRAINT "Hareket_pkey" PRIMARY KEY (hareketid);
 @   ALTER TABLE ONLY public.hareket DROP CONSTRAINT "Hareket_pkey";
       public            postgres    false    228            �           2606    16712 !   idaripersonel Idari Personel_pkey 
   CONSTRAINT     z   ALTER TABLE ONLY public.idaripersonel
    ADD CONSTRAINT "Idari Personel_pkey" PRIMARY KEY (idaripersonelid, personelid);
 M   ALTER TABLE ONLY public.idaripersonel DROP CONSTRAINT "Idari Personel_pkey";
       public            postgres    false    218    218            �           2606    16714    musteri Musteri_pkey 
   CONSTRAINT     [   ALTER TABLE ONLY public.musteri
    ADD CONSTRAINT "Musteri_pkey" PRIMARY KEY (musteriid);
 @   ALTER TABLE ONLY public.musteri DROP CONSTRAINT "Musteri_pkey";
       public            postgres    false    214            �           2606    16716    personel Personel_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.personel
    ADD CONSTRAINT "Personel_pkey" PRIMARY KEY (personelid);
 B   ALTER TABLE ONLY public.personel DROP CONSTRAINT "Personel_pkey";
       public            postgres    false    217            �           2606    16718 $   satisnoktalari Satis Noktaları_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public.satisnoktalari
    ADD CONSTRAINT "Satis Noktaları_pkey" PRIMARY KEY (subeid);
 P   ALTER TABLE ONLY public.satisnoktalari DROP CONSTRAINT "Satis Noktaları_pkey";
       public            postgres    false    230            �           2606    16720 #   sirketpersonel Sirket Personel_pkey 
   CONSTRAINT     }   ALTER TABLE ONLY public.sirketpersonel
    ADD CONSTRAINT "Sirket Personel_pkey" PRIMARY KEY (sirketpersonelid, personelid);
 O   ALTER TABLE ONLY public.sirketpersonel DROP CONSTRAINT "Sirket Personel_pkey";
       public            postgres    false    220    220            �           2606    16722 %   tarifebilgileri Tarife Bilgileri_pkey 
   CONSTRAINT     k   ALTER TABLE ONLY public.tarifebilgileri
    ADD CONSTRAINT "Tarife Bilgileri_pkey" PRIMARY KEY (tarifeid);
 Q   ALTER TABLE ONLY public.tarifebilgileri DROP CONSTRAINT "Tarife Bilgileri_pkey";
       public            postgres    false    232            �           2606    16724 !   trenpersoneli Tren Personeli_pkey 
   CONSTRAINT     m   ALTER TABLE ONLY public.trenpersoneli
    ADD CONSTRAINT "Tren Personeli_pkey" PRIMARY KEY (trenpersonelid);
 M   ALTER TABLE ONLY public.trenpersoneli DROP CONSTRAINT "Tren Personeli_pkey";
       public            postgres    false    233            �           2606    16726    tren Tren_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.tren
    ADD CONSTRAINT "Tren_pkey" PRIMARY KEY (trenid);
 :   ALTER TABLE ONLY public.tren DROP CONSTRAINT "Tren_pkey";
       public            postgres    false    224            �           2606    16728    vip VIP_pkey 
   CONSTRAINT     p   ALTER TABLE ONLY public.vip
    ADD CONSTRAINT "VIP_pkey" PRIMARY KEY (vipmusteriid, musteriid, vipmusteritcn);
 8   ALTER TABLE ONLY public.vip DROP CONSTRAINT "VIP_pkey";
       public            postgres    false    222    222    222            �           2606    16730    yht YHT_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public.yht
    ADD CONSTRAINT "YHT_pkey" PRIMARY KEY (yhtid, trenid);
 8   ALTER TABLE ONLY public.yht DROP CONSTRAINT "YHT_pkey";
       public            postgres    false    234    234            �           2606    16732    İstasyon İstasyon_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public."İstasyon"
    ADD CONSTRAINT "İstasyon_pkey" PRIMARY KEY (istasyonid);
 F   ALTER TABLE ONLY public."İstasyon" DROP CONSTRAINT "İstasyon_pkey";
       public            postgres    false    236            �           1259    16733    fki_hareketID_FK    INDEX     I   CREATE INDEX "fki_hareketID_FK" ON public.bilet USING btree (hareketid);
 &   DROP INDEX public."fki_hareketID_FK";
       public            postgres    false    226            �           1259    16734    fki_istasyonID_FK    INDEX     V   CREATE INDEX "fki_istasyonID_FK" ON public.hareketistasyonu USING btree (istasyonid);
 '   DROP INDEX public."fki_istasyonID_FK";
       public            postgres    false    229            �           1259    16735    fki_musteriID_FK    INDEX     I   CREATE INDEX "fki_musteriID_FK" ON public.bilet USING btree (musteriid);
 &   DROP INDEX public."fki_musteriID_FK";
       public            postgres    false    226            �           1259    16736    fki_personelID_FK    INDEX     T   CREATE INDEX "fki_personelID_FK" ON public.sirketpersonel USING btree (personelid);
 '   DROP INDEX public."fki_personelID_FK";
       public            postgres    false    220            �           1259    16737    fki_subeID_FK    INDEX     C   CREATE INDEX "fki_subeID_FK" ON public.bilet USING btree (subeid);
 #   DROP INDEX public."fki_subeID_FK";
       public            postgres    false    226            �           1259    16738    fki_tarifeID_FK    INDEX     G   CREATE INDEX "fki_tarifeID_FK" ON public.bilet USING btree (tarifeid);
 %   DROP INDEX public."fki_tarifeID_FK";
       public            postgres    false    226            �           1259    16739    fki_trenID_FK    INDEX     D   CREATE INDEX "fki_trenID_FK" ON public.anahat USING btree (trenid);
 #   DROP INDEX public."fki_trenID_FK";
       public            postgres    false    225            �           1259    16740    fki_vagonID_FK    INDEX     E   CREATE INDEX "fki_vagonID_FK" ON public.bilet USING btree (vagonid);
 $   DROP INDEX public."fki_vagonID_FK";
       public            postgres    false    226            �           2620    16741    tren engelliyolcutrig    TRIGGER     w   CREATE TRIGGER engelliyolcutrig AFTER INSERT ON public.tren FOR EACH ROW EXECUTE FUNCTION public.engelliyolcusayisi();
 .   DROP TRIGGER engelliyolcutrig ON public.tren;
       public          postgres    false    224    242            �           2620    16742    tren silinenengelliyolcutrig    TRIGGER     �   CREATE TRIGGER silinenengelliyolcutrig AFTER DELETE ON public.tren FOR EACH ROW EXECUTE FUNCTION public.deleteengelliyolcusayisi();
 5   DROP TRIGGER silinenengelliyolcutrig ON public.tren;
       public          postgres    false    239    224            �           2620    16743    tren silinenyolcutrig    TRIGGER     v   CREATE TRIGGER silinenyolcutrig AFTER DELETE ON public.tren FOR EACH ROW EXECUTE FUNCTION public.deleteyolcusayisi();
 .   DROP TRIGGER silinenyolcutrig ON public.tren;
       public          postgres    false    240    224            �           2620    16744    tren yolcutrig    TRIGGER     i   CREATE TRIGGER yolcutrig AFTER INSERT ON public.tren FOR EACH ROW EXECUTE FUNCTION public.yolcusayisi();
 '   DROP TRIGGER yolcutrig ON public.tren;
       public          postgres    false    245    224            �           2606    16745    bilet hareketID_FK    FK CONSTRAINT     �   ALTER TABLE ONLY public.bilet
    ADD CONSTRAINT "hareketID_FK" FOREIGN KEY (hareketid) REFERENCES public.hareket(hareketid) NOT VALID;
 >   ALTER TABLE ONLY public.bilet DROP CONSTRAINT "hareketID_FK";
       public          postgres    false    228    226    3283            �           2606    16750    hareketistasyonu hareketID_FK    FK CONSTRAINT     �   ALTER TABLE ONLY public.hareketistasyonu
    ADD CONSTRAINT "hareketID_FK" FOREIGN KEY (hareketid) REFERENCES public.hareket(hareketid) NOT VALID;
 I   ALTER TABLE ONLY public.hareketistasyonu DROP CONSTRAINT "hareketID_FK";
       public          postgres    false    228    3283    229            �           2606    16755    tren hareketID_FK    FK CONSTRAINT     �   ALTER TABLE ONLY public.tren
    ADD CONSTRAINT "hareketID_FK" FOREIGN KEY (hareketid) REFERENCES public.hareket(hareketid) NOT VALID;
 =   ALTER TABLE ONLY public.tren DROP CONSTRAINT "hareketID_FK";
       public          postgres    false    224    228    3283            �           2606    16760    hareketistasyonu istasyonID_FK    FK CONSTRAINT     �   ALTER TABLE ONLY public.hareketistasyonu
    ADD CONSTRAINT "istasyonID_FK" FOREIGN KEY (istasyonid) REFERENCES public."İstasyon"(istasyonid) NOT VALID;
 J   ALTER TABLE ONLY public.hareketistasyonu DROP CONSTRAINT "istasyonID_FK";
       public          postgres    false    229    236    3296            �           2606    16765    bilet musteriID_FK    FK CONSTRAINT     �   ALTER TABLE ONLY public.bilet
    ADD CONSTRAINT "musteriID_FK" FOREIGN KEY (musteriid) REFERENCES public.musteri(musteriid) NOT VALID;
 >   ALTER TABLE ONLY public.bilet DROP CONSTRAINT "musteriID_FK";
       public          postgres    false    214    3258    226            �           2606    16770    bireyselmusteri musteriID_FK    FK CONSTRAINT     �   ALTER TABLE ONLY public.bireyselmusteri
    ADD CONSTRAINT "musteriID_FK" FOREIGN KEY (musteriid) REFERENCES public.musteri(musteriid) NOT VALID;
 H   ALTER TABLE ONLY public.bireyselmusteri DROP CONSTRAINT "musteriID_FK";
       public          postgres    false    3258    214    215            �           2606    16775    vip musteriID_FK    FK CONSTRAINT     �   ALTER TABLE ONLY public.vip
    ADD CONSTRAINT "musteriID_FK" FOREIGN KEY (musteriid) REFERENCES public.musteri(musteriid) NOT VALID;
 <   ALTER TABLE ONLY public.vip DROP CONSTRAINT "musteriID_FK";
       public          postgres    false    222    214    3258            �           2606    16780    trenpersoneli personelID_FK    FK CONSTRAINT     �   ALTER TABLE ONLY public.trenpersoneli
    ADD CONSTRAINT "personelID_FK" FOREIGN KEY (personelid) REFERENCES public.personel(personelid) NOT VALID;
 G   ALTER TABLE ONLY public.trenpersoneli DROP CONSTRAINT "personelID_FK";
       public          postgres    false    217    233    3262            �           2606    16785    sirketpersonel personelID_FK    FK CONSTRAINT     �   ALTER TABLE ONLY public.sirketpersonel
    ADD CONSTRAINT "personelID_FK" FOREIGN KEY (personelid) REFERENCES public.personel(personelid) NOT VALID;
 H   ALTER TABLE ONLY public.sirketpersonel DROP CONSTRAINT "personelID_FK";
       public          postgres    false    220    217    3262            �           2606    16790    idaripersonel personelID_FK    FK CONSTRAINT     �   ALTER TABLE ONLY public.idaripersonel
    ADD CONSTRAINT "personelID_FK" FOREIGN KEY (personelid) REFERENCES public.personel(personelid) NOT VALID;
 G   ALTER TABLE ONLY public.idaripersonel DROP CONSTRAINT "personelID_FK";
       public          postgres    false    218    217    3262            �           2606    16795    bilet subeID_FK    FK CONSTRAINT     �   ALTER TABLE ONLY public.bilet
    ADD CONSTRAINT "subeID_FK" FOREIGN KEY (subeid) REFERENCES public.satisnoktalari(subeid) NOT VALID;
 ;   ALTER TABLE ONLY public.bilet DROP CONSTRAINT "subeID_FK";
       public          postgres    false    230    226    3288            �           2606    16800    bilet tarifeID_FK    FK CONSTRAINT     �   ALTER TABLE ONLY public.bilet
    ADD CONSTRAINT "tarifeID_FK" FOREIGN KEY (tarifeid) REFERENCES public.tarifebilgileri(tarifeid) NOT VALID;
 =   ALTER TABLE ONLY public.bilet DROP CONSTRAINT "tarifeID_FK";
       public          postgres    false    226    232    3290            �           2606    16805    musteri trenID_FK    FK CONSTRAINT     ~   ALTER TABLE ONLY public.musteri
    ADD CONSTRAINT "trenID_FK" FOREIGN KEY (trenid) REFERENCES public.tren(trenid) NOT VALID;
 =   ALTER TABLE ONLY public.musteri DROP CONSTRAINT "trenID_FK";
       public          postgres    false    214    224    3271            �           2606    16810    trenpersoneli trenID_FK    FK CONSTRAINT     �   ALTER TABLE ONLY public.trenpersoneli
    ADD CONSTRAINT "trenID_FK" FOREIGN KEY (trenid) REFERENCES public.tren(trenid) NOT VALID;
 C   ALTER TABLE ONLY public.trenpersoneli DROP CONSTRAINT "trenID_FK";
       public          postgres    false    3271    224    233            �           2606    16815    yht trenID_FK    FK CONSTRAINT     z   ALTER TABLE ONLY public.yht
    ADD CONSTRAINT "trenID_FK" FOREIGN KEY (trenid) REFERENCES public.tren(trenid) NOT VALID;
 9   ALTER TABLE ONLY public.yht DROP CONSTRAINT "trenID_FK";
       public          postgres    false    3271    224    234            �           2606    16820    anahat trenID_FK    FK CONSTRAINT     }   ALTER TABLE ONLY public.anahat
    ADD CONSTRAINT "trenID_FK" FOREIGN KEY (trenid) REFERENCES public.tren(trenid) NOT VALID;
 <   ALTER TABLE ONLY public.anahat DROP CONSTRAINT "trenID_FK";
       public          postgres    false    224    225    3271            �      x�3�4�,I-.F`ҘӄӐ+F��� ]U      �   m   x�m�;
�@D��.�������"j�xÂT&U/��{-�T+�S/�2+�yr�h`Og@ü��R.�p0-P��Ɠ�q�}l��y��������>���W=lx�� ��.p      �      x������ � �      �      x�3�2����� �+      �   7   x����0��=��i������TH����P���{�x�j��r���R��H~"n	=      �      x������ � �      �      x������ � �      �   �   x�M�;n�0��>L��ay��)W�B�Ll�L9��d��ݛ�{�l��>�������Pl'�L�"x�Bi���#c�m�o.8�K��Dl�ޝ���VRd�3�.�`�*��ط��Y��L��t�GVڠ�)Y��q"�i���J��Q�SM)kJ�!���x�;�	v�u�OP�*�J���Uɪ ��(ۣ�Η����g����(�GE}�      �   �   x�EαN�0���󻤲/1б�VHb(#�EN��8H�K��#yػ%y/�F��夓~�W���Ș>�3��;�����B�o�<���ck���R�TRZ� �s˽7v-�&i���Am�t�n0}5��2�%p�'�lg?"T��b�J%JL�'���*�����{g�o�Gv�#(���ҙ�D�.���ڜ��Y��-e�3����1��\���3�VE�5�u#��.JW]      �   I   x�3�<���$1/�4�3��*'��I$ 5/%3�˘�;?915'��=5�*����*7���)�(/�,�+F��� g�      �      x������ � �      �   \   x�3�t?��(;1��)�$5H{�X�id``�k`�kd�������ud�ǑQ��!>@f�c0nw�v�6�4151524�4����� 2��      �   5   x�3�43�t�������2�443��9��8�J�3�R���L8M��1z\\\  YG      �   u   x�3�4���,).M�,��Df:�%z$�p�qqqg�����H���1�1�Gei^Jb&��<�'��Ќ˄ӄ�54�?��NC䌸�8M9KR�K�8�S�RҋS��|cN�=... u�,(      �      x������ � �      �      x������ � �      �      x������ � �      �   $   x��G   �Ő���uЮ\:LȑW��>C;*      �   Y   x�3���ONL���tOM�J���2�<���$1/�4��;1������*�2&H2�y)�ٜ��9ɥ\���yىE����9%�sb���� �� �     