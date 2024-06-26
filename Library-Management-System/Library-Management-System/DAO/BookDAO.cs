﻿using Library_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Library_Management_System.DAO {
    class BookDAO : PadraoDAO<BookViewModel> {
        protected override SqlParameter[] CriaParametros(BookViewModel book, bool isInsert = false) {
            List<SqlParameter> parametros = new List<SqlParameter>();

            if (!isInsert) {
                parametros.Add(new SqlParameter("BookId", book.Id));
            }

            parametros.Add(new SqlParameter ("AuthorId", book.AuthorId));
            parametros.Add(new SqlParameter("CategoryId", book.CategoryId));
            parametros.Add(new SqlParameter("Title", book.Title));
            parametros.Add(new SqlParameter("ISBN", book.ISBN));
            parametros.Add(new SqlParameter("PublishedYear", book.PublishedYear));
            parametros.Add(new SqlParameter("Image", HelperDAO.NullAsDbNull(book.ImageByte)));
            return parametros.ToArray();
        }

        protected override BookViewModel MontaModel(DataRow registro) {
            BookViewModel b = new BookViewModel()
            {
                Id = Convert.ToInt32(registro["BookId"]),
                AuthorId = Convert.ToInt32(registro["AuthorId"]),
                CategoryId = Convert.ToInt32(registro["CategoryId"]),
                Title = registro["Title"].ToString(),
                ISBN = registro["ISBN"].ToString(),
                PublishedYear = Convert.ToInt32(registro["PublishedYear"]),
            };

            if (registro["Image"] != DBNull.Value)
                b.ImageByte = registro["Image"] as byte[];
            if (registro.Table.Columns.Contains("AuthorName"))
                b.AuthorName = registro["AuthorName"].ToString();
            if (registro.Table.Columns.Contains("CategoryDescription"))
                b.CategoryDescription = registro["CategoryDescription"].ToString();

            return b;
        }

        protected override void SetTabela() {
            Tabela = "Book";
            NomeSpListagem = "spListagem_Book";
            NomeSpDelete = "spDelete_Book_And_Loans";
        }

        public List<BookViewModel> ConsultaAvancada(string descricao, int autor, int categoria, int dataInicial, int dataFinal)
        {
            SqlParameter[] p = {
             new SqlParameter("descricao", descricao),
             new SqlParameter("autor", autor),
             new SqlParameter("categoria", categoria),
             new SqlParameter("dataInicial", dataInicial),
             new SqlParameter("dataFinal", dataFinal),
             };
            var tabela = HelperDAO.ExecutaProcSelect("spConsultaAvancada_Book", p);
            var lista = new List<BookViewModel>();
            foreach (DataRow dr in tabela.Rows)
                lista.Add(MontaModel(dr));
            return lista;
        }

    }
}
