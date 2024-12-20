PGDMP                  
    |            educationBD    17.0    17.0     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                           false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                           false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                           false            �           1262    24785    educationBD    DATABASE     �   CREATE DATABASE "educationBD" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE "educationBD";
                     postgres    false            �            1259    24793    disciplines    TABLE     �   CREATE TABLE public.disciplines (
    discipline_id integer NOT NULL,
    name character varying(255),
    complexity integer
);
    DROP TABLE public.disciplines;
       public         heap r       postgres    false            �            1259    24798    enrollments    TABLE     �   CREATE TABLE public.enrollments (
    enrollment_id integer NOT NULL,
    student_id integer,
    discipline_id integer,
    score integer
);
    DROP TABLE public.enrollments;
       public         heap r       postgres    false            �            1259    24786    students    TABLE     �   CREATE TABLE public.students (
    student_id integer NOT NULL,
    name character varying(255),
    age integer,
    groupe character varying(255),
    city character varying(255)
);
    DROP TABLE public.students;
       public         heap r       postgres    false            �          0    24793    disciplines 
   TABLE DATA           F   COPY public.disciplines (discipline_id, name, complexity) FROM stdin;
    public               postgres    false    218          �          0    24798    enrollments 
   TABLE DATA           V   COPY public.enrollments (enrollment_id, student_id, discipline_id, score) FROM stdin;
    public               postgres    false    219   �       �          0    24786    students 
   TABLE DATA           G   COPY public.students (student_id, name, age, groupe, city) FROM stdin;
    public               postgres    false    217   �       a           2606    24797    disciplines disciplines_pkey 
   CONSTRAINT     e   ALTER TABLE ONLY public.disciplines
    ADD CONSTRAINT disciplines_pkey PRIMARY KEY (discipline_id);
 F   ALTER TABLE ONLY public.disciplines DROP CONSTRAINT disciplines_pkey;
       public                 postgres    false    218            c           2606    24802    enrollments enrollments_pkey 
   CONSTRAINT     e   ALTER TABLE ONLY public.enrollments
    ADD CONSTRAINT enrollments_pkey PRIMARY KEY (enrollment_id);
 F   ALTER TABLE ONLY public.enrollments DROP CONSTRAINT enrollments_pkey;
       public                 postgres    false    219            _           2606    24792    students students_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.students
    ADD CONSTRAINT students_pkey PRIMARY KEY (student_id);
 @   ALTER TABLE ONLY public.students DROP CONSTRAINT students_pkey;
       public                 postgres    false    217            d           2606    24808 *   enrollments enrollments_discipline_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.enrollments
    ADD CONSTRAINT enrollments_discipline_id_fkey FOREIGN KEY (discipline_id) REFERENCES public.disciplines(discipline_id);
 T   ALTER TABLE ONLY public.enrollments DROP CONSTRAINT enrollments_discipline_id_fkey;
       public               postgres    false    218    219    4705            e           2606    24803 '   enrollments enrollments_student_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.enrollments
    ADD CONSTRAINT enrollments_student_id_fkey FOREIGN KEY (student_id) REFERENCES public.students(student_id);
 Q   ALTER TABLE ONLY public.enrollments DROP CONSTRAINT enrollments_student_id_fkey;
       public               postgres    false    4703    217    219            �   t   x�-���@D��*� 	�tC1��� Q�:�a�kx�#�`4�|7ƕ2߅+#�Zo��8����d�0��JV�5.�5Ǟ�5�g�/>ʼ�הx%N�*m�����|�v�v@Nh      �   G   x���� Cѳ�0��]��5��O���SI�B=xuy�e�� ]�[w��h�gS�R5��S0����{�]��      �   �   x�u�1�0��+�ˎA"�1��P�R�($+�E�����EIg�w��ZLHX�ָ�ސ��;��p�K>rg���J�"����(X�؍�c���g�yB��1�4#��Tɏ�&^jCx�8fY�h�F�����V4"�0��ˍ�A��r^d�F)��N~�     