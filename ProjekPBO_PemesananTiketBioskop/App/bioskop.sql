PGDMP  .    6    	            |            bioskop    17.0    17.0 3    '           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                           false            (           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                           false            )           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                           false            *           1262    16795    bioskop    DATABASE     �   CREATE DATABASE bioskop WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United States.1252';
    DROP DATABASE bioskop;
                     postgres    false            �            1259    16796    akun    TABLE     
  CREATE TABLE public.akun (
    akun_id integer NOT NULL,
    username character varying(50) NOT NULL,
    password character varying(255) NOT NULL,
    email character varying(100) NOT NULL,
    nomor_telepon character varying(15),
    role character varying(15)
);
    DROP TABLE public.akun;
       public         heap r       postgres    false            �            1259    16799    detail_film    TABLE     �   CREATE TABLE public.detail_film (
    detailfilm_id integer NOT NULL,
    ruangan_id integer,
    kursi_id integer,
    film_id integer
);
    DROP TABLE public.detail_film;
       public         heap r       postgres    false            �            1259    16802    detail_fillm_detailfilm_id_seq    SEQUENCE     �   CREATE SEQUENCE public.detail_fillm_detailfilm_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 5   DROP SEQUENCE public.detail_fillm_detailfilm_id_seq;
       public               postgres    false    218            +           0    0    detail_fillm_detailfilm_id_seq    SEQUENCE OWNED BY     `   ALTER SEQUENCE public.detail_fillm_detailfilm_id_seq OWNED BY public.detail_film.detailfilm_id;
          public               postgres    false    219            �            1259    16803    film    TABLE     �  CREATE TABLE public.film (
    film_id integer NOT NULL,
    judul_film character varying(100) NOT NULL,
    genre character varying(50),
    sutradara character varying(50),
    produksi character varying(50),
    aktor character varying(100),
    batas_umur integer,
    durasi character varying(20),
    sinopsis text,
    harga integer,
    gambar bytea NOT NULL,
    status character varying(15),
    waktu_tayang time without time zone,
    tanggal_tayang date
);
    DROP TABLE public.film;
       public         heap r       postgres    false            �            1259    16808    film_film_id_seq    SEQUENCE     �   CREATE SEQUENCE public.film_film_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.film_film_id_seq;
       public               postgres    false    220            ,           0    0    film_film_id_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.film_film_id_seq OWNED BY public.film.film_id;
          public               postgres    false    221            �            1259    16809    kursi    TABLE     0  CREATE TABLE public.kursi (
    kursi_id integer NOT NULL,
    nomor_kursi character varying(10) NOT NULL,
    status character varying(20) NOT NULL,
    CONSTRAINT kursi_status_check CHECK (((status)::text = ANY (ARRAY[('Tersedia'::character varying)::text, ('Terpesan'::character varying)::text])))
);
    DROP TABLE public.kursi;
       public         heap r       postgres    false            �            1259    16813    kursi_kursi_id_seq    SEQUENCE     �   CREATE SEQUENCE public.kursi_kursi_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.kursi_kursi_id_seq;
       public               postgres    false    222            -           0    0    kursi_kursi_id_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.kursi_kursi_id_seq OWNED BY public.kursi.kursi_id;
          public               postgres    false    223            �            1259    16814    pelanggan_pelanggan_id_seq    SEQUENCE     �   CREATE SEQUENCE public.pelanggan_pelanggan_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public.pelanggan_pelanggan_id_seq;
       public               postgres    false    217            .           0    0    pelanggan_pelanggan_id_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public.pelanggan_pelanggan_id_seq OWNED BY public.akun.akun_id;
          public               postgres    false    224            �            1259    16815    ruangan    TABLE     r   CREATE TABLE public.ruangan (
    ruangan_id integer NOT NULL,
    nama_ruangan character varying(10) NOT NULL
);
    DROP TABLE public.ruangan;
       public         heap r       postgres    false            �            1259    16818    ruangan_ruangan_id_seq    SEQUENCE     �   CREATE SEQUENCE public.ruangan_ruangan_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.ruangan_ruangan_id_seq;
       public               postgres    false    225            /           0    0    ruangan_ruangan_id_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.ruangan_ruangan_id_seq OWNED BY public.ruangan.ruangan_id;
          public               postgres    false    226            �            1259    16819 	   transaksi    TABLE     �   CREATE TABLE public.transaksi (
    transaksi_id integer NOT NULL,
    pelanggan_id integer,
    detailfilm_id integer,
    waktu_transaksi time without time zone,
    tanggal_transaksi date,
    metode_pembayaran character varying(50)
);
    DROP TABLE public.transaksi;
       public         heap r       postgres    false            �            1259    16822    transaksi_transaksi_id_seq    SEQUENCE     �   CREATE SEQUENCE public.transaksi_transaksi_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public.transaksi_transaksi_id_seq;
       public               postgres    false    227            0           0    0    transaksi_transaksi_id_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public.transaksi_transaksi_id_seq OWNED BY public.transaksi.transaksi_id;
          public               postgres    false    228            p           2604    16823    akun akun_id    DEFAULT     v   ALTER TABLE ONLY public.akun ALTER COLUMN akun_id SET DEFAULT nextval('public.pelanggan_pelanggan_id_seq'::regclass);
 ;   ALTER TABLE public.akun ALTER COLUMN akun_id DROP DEFAULT;
       public               postgres    false    224    217            q           2604    16824    detail_film detailfilm_id    DEFAULT     �   ALTER TABLE ONLY public.detail_film ALTER COLUMN detailfilm_id SET DEFAULT nextval('public.detail_fillm_detailfilm_id_seq'::regclass);
 H   ALTER TABLE public.detail_film ALTER COLUMN detailfilm_id DROP DEFAULT;
       public               postgres    false    219    218            r           2604    16825    film film_id    DEFAULT     l   ALTER TABLE ONLY public.film ALTER COLUMN film_id SET DEFAULT nextval('public.film_film_id_seq'::regclass);
 ;   ALTER TABLE public.film ALTER COLUMN film_id DROP DEFAULT;
       public               postgres    false    221    220            s           2604    16826    kursi kursi_id    DEFAULT     p   ALTER TABLE ONLY public.kursi ALTER COLUMN kursi_id SET DEFAULT nextval('public.kursi_kursi_id_seq'::regclass);
 =   ALTER TABLE public.kursi ALTER COLUMN kursi_id DROP DEFAULT;
       public               postgres    false    223    222            t           2604    16827    ruangan ruangan_id    DEFAULT     x   ALTER TABLE ONLY public.ruangan ALTER COLUMN ruangan_id SET DEFAULT nextval('public.ruangan_ruangan_id_seq'::regclass);
 A   ALTER TABLE public.ruangan ALTER COLUMN ruangan_id DROP DEFAULT;
       public               postgres    false    226    225            u           2604    16828    transaksi transaksi_id    DEFAULT     �   ALTER TABLE ONLY public.transaksi ALTER COLUMN transaksi_id SET DEFAULT nextval('public.transaksi_transaksi_id_seq'::regclass);
 E   ALTER TABLE public.transaksi ALTER COLUMN transaksi_id DROP DEFAULT;
       public               postgres    false    228    227                      0    16796    akun 
   TABLE DATA           W   COPY public.akun (akun_id, username, password, email, nomor_telepon, role) FROM stdin;
    public               postgres    false    217   �=                 0    16799    detail_film 
   TABLE DATA           S   COPY public.detail_film (detailfilm_id, ruangan_id, kursi_id, film_id) FROM stdin;
    public               postgres    false    218   ]>                 0    16803    film 
   TABLE DATA           �   COPY public.film (film_id, judul_film, genre, sutradara, produksi, aktor, batas_umur, durasi, sinopsis, harga, gambar, status, waktu_tayang, tanggal_tayang) FROM stdin;
    public               postgres    false    220   z>                 0    16809    kursi 
   TABLE DATA           >   COPY public.kursi (kursi_id, nomor_kursi, status) FROM stdin;
    public               postgres    false    222   �>       !          0    16815    ruangan 
   TABLE DATA           ;   COPY public.ruangan (ruangan_id, nama_ruangan) FROM stdin;
    public               postgres    false    225   �>       #          0    16819 	   transaksi 
   TABLE DATA           �   COPY public.transaksi (transaksi_id, pelanggan_id, detailfilm_id, waktu_transaksi, tanggal_transaksi, metode_pembayaran) FROM stdin;
    public               postgres    false    227   �>       1           0    0    detail_fillm_detailfilm_id_seq    SEQUENCE SET     L   SELECT pg_catalog.setval('public.detail_fillm_detailfilm_id_seq', 3, true);
          public               postgres    false    219            2           0    0    film_film_id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.film_film_id_seq', 52, true);
          public               postgres    false    221            3           0    0    kursi_kursi_id_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.kursi_kursi_id_seq', 1, false);
          public               postgres    false    223            4           0    0    pelanggan_pelanggan_id_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public.pelanggan_pelanggan_id_seq', 4, true);
          public               postgres    false    224            5           0    0    ruangan_ruangan_id_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public.ruangan_ruangan_id_seq', 3, true);
          public               postgres    false    226            6           0    0    transaksi_transaksi_id_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.transaksi_transaksi_id_seq', 1, false);
          public               postgres    false    228            z           2606    16830    detail_film detail_fillm_pkey 
   CONSTRAINT     f   ALTER TABLE ONLY public.detail_film
    ADD CONSTRAINT detail_fillm_pkey PRIMARY KEY (detailfilm_id);
 G   ALTER TABLE ONLY public.detail_film DROP CONSTRAINT detail_fillm_pkey;
       public                 postgres    false    218            |           2606    16832    film film_pkey 
   CONSTRAINT     Q   ALTER TABLE ONLY public.film
    ADD CONSTRAINT film_pkey PRIMARY KEY (film_id);
 8   ALTER TABLE ONLY public.film DROP CONSTRAINT film_pkey;
       public                 postgres    false    220            ~           2606    16834    kursi kursi_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.kursi
    ADD CONSTRAINT kursi_pkey PRIMARY KEY (kursi_id);
 :   ALTER TABLE ONLY public.kursi DROP CONSTRAINT kursi_pkey;
       public                 postgres    false    222            x           2606    16836    akun pelanggan_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.akun
    ADD CONSTRAINT pelanggan_pkey PRIMARY KEY (akun_id);
 =   ALTER TABLE ONLY public.akun DROP CONSTRAINT pelanggan_pkey;
       public                 postgres    false    217            �           2606    16838    ruangan ruangan_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.ruangan
    ADD CONSTRAINT ruangan_pkey PRIMARY KEY (ruangan_id);
 >   ALTER TABLE ONLY public.ruangan DROP CONSTRAINT ruangan_pkey;
       public                 postgres    false    225            �           2606    16840    transaksi transaksi_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.transaksi
    ADD CONSTRAINT transaksi_pkey PRIMARY KEY (transaksi_id);
 B   ALTER TABLE ONLY public.transaksi DROP CONSTRAINT transaksi_pkey;
       public                 postgres    false    227            �           2606    16841 &   detail_film detail_fillm_kursi_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.detail_film
    ADD CONSTRAINT detail_fillm_kursi_id_fkey FOREIGN KEY (kursi_id) REFERENCES public.kursi(kursi_id) ON DELETE CASCADE;
 P   ALTER TABLE ONLY public.detail_film DROP CONSTRAINT detail_fillm_kursi_id_fkey;
       public               postgres    false    222    4734    218            �           2606    16846 (   detail_film detail_fillm_ruangan_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.detail_film
    ADD CONSTRAINT detail_fillm_ruangan_id_fkey FOREIGN KEY (ruangan_id) REFERENCES public.ruangan(ruangan_id) ON DELETE CASCADE;
 R   ALTER TABLE ONLY public.detail_film DROP CONSTRAINT detail_fillm_ruangan_id_fkey;
       public               postgres    false    4736    225    218            �           2606    16851    detail_film fk_film    FK CONSTRAINT     �   ALTER TABLE ONLY public.detail_film
    ADD CONSTRAINT fk_film FOREIGN KEY (film_id) REFERENCES public.film(film_id) ON DELETE CASCADE;
 =   ALTER TABLE ONLY public.detail_film DROP CONSTRAINT fk_film;
       public               postgres    false    218    220    4732            �           2606    16856 &   transaksi transaksi_detailfilm_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.transaksi
    ADD CONSTRAINT transaksi_detailfilm_id_fkey FOREIGN KEY (detailfilm_id) REFERENCES public.detail_film(detailfilm_id) ON DELETE CASCADE;
 P   ALTER TABLE ONLY public.transaksi DROP CONSTRAINT transaksi_detailfilm_id_fkey;
       public               postgres    false    227    218    4730            �           2606    16861 %   transaksi transaksi_pelanggan_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.transaksi
    ADD CONSTRAINT transaksi_pelanggan_id_fkey FOREIGN KEY (pelanggan_id) REFERENCES public.akun(akun_id) ON DELETE CASCADE;
 O   ALTER TABLE ONLY public.transaksi DROP CONSTRAINT transaksi_pelanggan_id_fkey;
       public               postgres    false    217    227    4728               ^   x�3�L,�,��442�a�!=713G/9?������������Ԕ� 5'1/==1�˄31��F��)��y�@,�Ԋ�܂�TL���\1z\\\ ��%-            x������ � �            x������ � �            x������ � �      !   "   x�3�*M�KO�Sp�2������lg�=... ��      #      x������ � �     