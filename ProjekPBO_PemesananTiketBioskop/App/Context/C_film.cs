using core;
using Npgsql;
using ProjekPBO_PemesananTiketBioskop.App.Model;
using System.Data;



namespace ProjekPBO_PemesananTiketBioskop.App.Context
{
    internal class C_film : DatabaseWrapper
    {
        private static string table = "film";

        public static DataTable All()
        {
            string query = @"
            SELECT *
            FROM film";


            DataTable dataFilm = queryExecutor(query);


            return dataFilm;
        }
        public static int addDataFilm(M_Film dataFilm)
        {
            string query = $"INSERT INTO {table}(judul_film, genre, sutradara, produksi, aktor, batas_umur, durasi, sinopsis, harga, gambar, status, waktu_tayang, tanggal_tayang) " +
                           "VALUES(@judul_film, @genre, @sutradara, @produksi, @aktor, @batas_umur, @durasi, @sinopsis, @harga, @gambar, @status, @waktuTayang, @tanggalTayang) " +
                           "RETURNING film_id;"; // Menambahkan RETURNING untuk mengambil ID film yang baru

            // Menyiapkan parameter untuk query
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@judul_film", dataFilm.judul_film),
                new NpgsqlParameter("@genre", dataFilm.genre),
                new NpgsqlParameter("@sutradara", dataFilm.sutradara),
                new NpgsqlParameter("@produksi", dataFilm.produksi),
                new NpgsqlParameter("@aktor", dataFilm.aktor),
                new NpgsqlParameter("@batas_umur", dataFilm.batas_umur),
                new NpgsqlParameter("@durasi", dataFilm.durasi),
                new NpgsqlParameter("@sinopsis", string.IsNullOrWhiteSpace(dataFilm.sinopsis) ? (object)DBNull.Value : dataFilm.sinopsis),
                new NpgsqlParameter("@harga", dataFilm.harga),
                new NpgsqlParameter("@gambar", dataFilm.gambar),
                new NpgsqlParameter("@status", dataFilm.status),
                new NpgsqlParameter("@waktuTayang", dataFilm.waktuTayang),
                new NpgsqlParameter("@tanggalTayang", dataFilm.tanggalTayang)
    };

            // Menjalankan query dan mendapatkan ID film yang baru dimasukkan
            var result = ExecuteScalarCommand(query, parameters);

            // Memastikan bahwa hasil yang didapat bisa dikonversi menjadi int
            if (result != null && int.TryParse(result.ToString(), out int filmId))
            {
                return filmId;  // Mengembalikan ID film yang baru
            }

            // Jika tidak berhasil mendapatkan ID, kembalikan nilai default
            return 0;
        }
        public static void UpdateFilm(M_Film dataFilm)
        {
            string query = $@"
            UPDATE {table}
            SET 
                judul_film = @judul_film, 
                genre = @genre, 
                sutradara = @sutradara, 
                produksi = @produksi, 
                aktor = @aktor, 
                batas_umur = @batas_umur, 
                durasi = @durasi, 
                sinopsis = @sinopsis, 
                harga = @harga, 
                gambar = @gambar, 
                status = @status, 
                waktu_tayang = @waktuTayang, 
                tanggal_tayang = @tanggalTayang
            WHERE 
                film_id = @film_id";

            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@judul_film", dataFilm.judul_film),
            new NpgsqlParameter("@genre", dataFilm.genre),
            new NpgsqlParameter("@sutradara", dataFilm.sutradara),
            new NpgsqlParameter("@produksi", dataFilm.produksi),
            new NpgsqlParameter("@aktor", dataFilm.aktor),
            new NpgsqlParameter("@batas_umur", dataFilm.batas_umur),
            new NpgsqlParameter("@durasi", dataFilm.durasi),
            new NpgsqlParameter("@sinopsis", string.IsNullOrWhiteSpace(dataFilm.sinopsis) ? (object)DBNull.Value : dataFilm.sinopsis),
            new NpgsqlParameter("@harga", dataFilm.harga),
            new NpgsqlParameter("@gambar", dataFilm.gambar),
            new NpgsqlParameter("@status", dataFilm.status),
            new NpgsqlParameter("@waktuTayang", dataFilm.waktuTayang),
            new NpgsqlParameter("@tanggalTayang", dataFilm.tanggalTayang),
            new NpgsqlParameter("@film_id", dataFilm.film_id)
        };

            commandExecutor(query, parameters);
        }

        public static M_Film GetFilmById(int filmId)
        {
            string query = $"SELECT * FROM {table} WHERE film_id = @film_id";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@film_id", filmId)
            };

            DataTable data = queryExecutor(query, parameters);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                return new M_Film
                {
                    film_id = Convert.ToInt32(row["film_id"]),
                    judul_film = row["judul_film"].ToString(),
                    genre = row["genre"].ToString(),
                    sutradara = row["sutradara"].ToString(),
                    produksi = row["produksi"].ToString(),
                    aktor = row["aktor"].ToString(),
                    batas_umur = Convert.ToInt32(row["batas_umur"]),
                    durasi = row["durasi"].ToString(),
                    sinopsis = row["sinopsis"] == DBNull.Value ? null : row["sinopsis"].ToString(),
                    harga = Convert.ToInt32(row["harga"]),
                    gambar = (byte[])row["gambar"],
                    status = row["status"].ToString(),
                    waktuTayang = (TimeSpan)row["waktu_tayang"],
                    tanggalTayang = (DateTime)row["tanggal_tayang"]
                };
            }

            return null;
        }


        public static DataTable getdataFilm()
        {
            string query = @"
        SELECT  
            film.film_id,
            film.judul_film, 
            film.genre, 
            film.sutradara, 
            film.produksi, 
            film.aktor, 
            film.batas_umur, 
            film.durasi, 
            film.sinopsis,
            film.waktu_tayang,
            film.tanggal_tayang,
            film.harga, 
            film.status,
            ruangan.nama_ruangan
        FROM 
            detail_film
        JOIN 
            film ON detail_film.film_id = film.film_id
        JOIN 
            ruangan ON detail_film.ruangan_id = ruangan.ruangan_id;";

            DataTable dataFilm = queryExecutor(query);
            return dataFilm;
        }

        public static List<M_Film> GetFilmsByFilter(string usiaFilter)
        {
            string query = usiaFilter.ToLower() switch
            {
                "13+" => $"SELECT * FROM {table} WHERE batas_umur >= 13 AND status = 'Sedang Tayang'",
                "17+" => $"SELECT * FROM {table} WHERE batas_umur >= 17 AND status = 'Sedang Tayang'",
                _ => $"SELECT * FROM {table} WHERE status = 'Sedang Tayang'" // Default: select all films that are currently showing

            };

            DataTable data = queryExecutor(query);
            List<M_Film> filmList = new List<M_Film>();

            foreach (DataRow row in data.Rows)
            {
                filmList.Add(new M_Film
                {
                    film_id = Convert.ToInt32(row["film_id"]),
                    judul_film = row["judul_film"].ToString(),
                    genre = row["genre"].ToString(),
                    sutradara = row["sutradara"].ToString(),
                    produksi = row["produksi"].ToString(),
                    aktor = row["aktor"].ToString(),
                    batas_umur = Convert.ToInt32(row["batas_umur"]),
                    durasi = row["durasi"].ToString(),
                    sinopsis = row["sinopsis"] == DBNull.Value ? null : row["sinopsis"].ToString(),
                    harga = Convert.ToInt32(row["harga"]),
                    gambar = row["gambar"] == DBNull.Value ? null : (byte[])row["gambar"],
                    status = row["status"].ToString(),
                    waktuTayang = (TimeSpan)row["waktu_tayang"],
                    tanggalTayang = (DateTime)row["tanggal_tayang"]
                });
            }

            return filmList;
        }

        public static (M_Film, M_RuanganFilm, int) GetDataFilmAndRuangan(int filmId)
        {
            string query = @"
    SELECT  
        film.film_id,
        film.judul_film, 
        film.genre, 
        film.sutradara, 
        film.produksi, 
        film.aktor, 
        film.batas_umur, 
        film.durasi, 
        film.sinopsis, 
        film.harga, 
        film.gambar, 
        film.status,
        film.waktu_tayang,
        film.tanggal_tayang,
        ruangan.nama_ruangan,
        detail_film.detailfilm_id
    FROM 
        detail_film
    JOIN 
        film ON detail_film.film_id = film.film_id
    JOIN 
        ruangan ON detail_film.ruangan_id = ruangan.ruangan_id
    WHERE 
        film.film_id = @filmId";

            // Parameter untuk query
            NpgsqlParameter[] parameters =
            {
        new NpgsqlParameter("@filmId", filmId)
    };

            // Eksekusi query menggunakan DatabaseWrapper
            DataTable data = DatabaseWrapper.queryExecutor(query, parameters);

            // Inisialisasi objek film, ruangan, dan detailfilmID
            M_Film film = null;
            M_RuanganFilm ruangan = null;
            int detailfilmID = 0;

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];

                // Isi data film
                film = new M_Film
                {
                    film_id = Convert.ToInt32(row["film_id"]),
                    judul_film = row["judul_film"].ToString(),
                    genre = row["genre"].ToString(),
                    sutradara = row["sutradara"].ToString(),
                    produksi = row["produksi"].ToString(),
                    aktor = row["aktor"].ToString(),
                    batas_umur = Convert.ToInt32(row["batas_umur"]),
                    durasi = row["durasi"].ToString(),
                    sinopsis = row["sinopsis"] == DBNull.Value ? null : row["sinopsis"].ToString(),
                    harga = Convert.ToInt32(row["harga"]),
                    gambar = row["gambar"] == DBNull.Value ? null : (byte[])row["gambar"],
                    status = row["status"].ToString(),
                    waktuTayang = (TimeSpan)row["waktu_tayang"],
                    tanggalTayang = (DateTime)row["tanggal_tayang"]
                };

                // Isi data ruangan
                ruangan = new M_RuanganFilm
                {
                    nama_ruangan = row["nama_ruangan"].ToString()
                };

                // Isi detailfilmID
                detailfilmID = Convert.ToInt32(row["detailfilm_id"]);
            }

            // Mengembalikan tuple
            return (film, ruangan, detailfilmID);
        }


    }
}

