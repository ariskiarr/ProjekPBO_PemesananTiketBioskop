PGDMP  5    7    
        
    |            databasePBO    17.0    17.0     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                           false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                           false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                           false            �           1262    16597    databasePBO    DATABASE     �   CREATE DATABASE "databasePBO" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United States.1252';
    DROP DATABASE "databasePBO";
                     postgres    false            �            1259    16598 	   mahasiswa    TABLE     �   CREATE TABLE public.mahasiswa (
    id integer NOT NULL,
    nama character varying NOT NULL,
    nim character varying NOT NULL,
    email character varying NOT NULL,
    semester integer NOT NULL,
    id_prodi integer NOT NULL
);
    DROP TABLE public.mahasiswa;
       public         heap r       postgres    false            �            1259    16603    mahasiswa_id_seq    SEQUENCE     �   CREATE SEQUENCE public.mahasiswa_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.mahasiswa_id_seq;
       public               postgres    false    217            �           0    0    mahasiswa_id_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.mahasiswa_id_seq OWNED BY public.mahasiswa.id;
          public               postgres    false    218            �            1259    16604    prodi    TABLE     b   CREATE TABLE public.prodi (
    id integer NOT NULL,
    nama_prodi character varying NOT NULL
);
    DROP TABLE public.prodi;
       public         heap r       postgres    false            �            1259    16609    prodi_id_seq    SEQUENCE     �   CREATE SEQUENCE public.prodi_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.prodi_id_seq;
       public               postgres    false    219            �           0    0    prodi_id_seq    SEQUENCE OWNED BY     =   ALTER SEQUENCE public.prodi_id_seq OWNED BY public.prodi.id;
          public               postgres    false    220            \           2604    16610    mahasiswa id    DEFAULT     l   ALTER TABLE ONLY public.mahasiswa ALTER COLUMN id SET DEFAULT nextval('public.mahasiswa_id_seq'::regclass);
 ;   ALTER TABLE public.mahasiswa ALTER COLUMN id DROP DEFAULT;
       public               postgres    false    218    217            ]           2604    16611    prodi id    DEFAULT     d   ALTER TABLE ONLY public.prodi ALTER COLUMN id SET DEFAULT nextval('public.prodi_id_seq'::regclass);
 7   ALTER TABLE public.prodi ALTER COLUMN id DROP DEFAULT;
       public               postgres    false    220    219            �          0    16598 	   mahasiswa 
   TABLE DATA           M   COPY public.mahasiswa (id, nama, nim, email, semester, id_prodi) FROM stdin;
    public               postgres    false    217   N       �          0    16604    prodi 
   TABLE DATA           /   COPY public.prodi (id, nama_prodi) FROM stdin;
    public               postgres    false    219   k       �           0    0    mahasiswa_id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.mahasiswa_id_seq', 12, true);
          public               postgres    false    218                        0    0    prodi_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.prodi_id_seq', 3, true);
          public               postgres    false    220            _           2606    16613    mahasiswa mahasiswa_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.mahasiswa
    ADD CONSTRAINT mahasiswa_pkey PRIMARY KEY (id);
 B   ALTER TABLE ONLY public.mahasiswa DROP CONSTRAINT mahasiswa_pkey;
       public                 postgres    false    217            a           2606    16615    prodi prodi_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.prodi
    ADD CONSTRAINT prodi_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.prodi DROP CONSTRAINT prodi_pkey;
       public                 postgres    false    219            �      x������ � �      �   5   x�3��,.I�U��K�/�M,��2�I�����O�D5愲K2��b���� n��     