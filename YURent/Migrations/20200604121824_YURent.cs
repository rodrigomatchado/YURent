using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YURent.Migrations
{
    public partial class YURent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anuncio",
                columns: table => new
                {
                    id_anuncio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_utilizador = table.Column<int>(nullable: false),
                    nome = table.Column<string>(nullable: true),
                    descricao = table.Column<string>(nullable: true),
                    categoria = table.Column<string>(nullable: true),
                    preco_dia = table.Column<float>(nullable: false),
                    visualizacoes = table.Column<int>(nullable: false),
                    extensao_imagem = table.Column<string>(nullable: true),
                    ativo = table.Column<bool>(nullable: false),
                    data_publicacao = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anuncio", x => x.id_anuncio);
                });

            migrationBuilder.CreateTable(
                name: "Faturacao",
                columns: table => new
                {
                    id_faturacao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_utilizador = table.Column<int>(nullable: false),
                    nome_completo = table.Column<string>(nullable: true),
                    morada = table.Column<string>(nullable: true),
                    codigo_postal = table.Column<string>(nullable: true),
                    nif = table.Column<int>(nullable: false),
                    iban = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faturacao", x => x.id_faturacao);
                });

            migrationBuilder.CreateTable(
                name: "Guardado",
                columns: table => new
                {
                    id_guardado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_anuncio = table.Column<int>(nullable: false),
                    id_utilizador = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guardado", x => x.id_guardado);
                });

            migrationBuilder.CreateTable(
                name: "Mensagem",
                columns: table => new
                {
                    id_mensagem = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_utilizador = table.Column<int>(nullable: false),
                    id_anuncio = table.Column<int>(nullable: false),
                    fromseller = table.Column<bool>(nullable: false),
                    conteudo = table.Column<string>(nullable: true),
                    vista = table.Column<bool>(nullable: false),
                    data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensagem", x => x.id_mensagem);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    id_reserva = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_anuncio = table.Column<int>(nullable: false),
                    id_utilizador = table.Column<int>(nullable: false),
                    data_inicio = table.Column<DateTime>(nullable: false),
                    data_fim = table.Column<DateTime>(nullable: false),
                    preco = table.Column<float>(nullable: false),
                    cancelado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.id_reserva);
                });

            migrationBuilder.CreateTable(
                name: "Transacoes",
                columns: table => new
                {
                    id_transacoes = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_reserva = table.Column<int>(nullable: false),
                    data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transacoes", x => x.id_transacoes);
                });

            migrationBuilder.CreateTable(
                name: "Utilizador",
                columns: table => new
                {
                    id_utilizador = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    nome = table.Column<string>(nullable: true),
                    avatar_extensao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizador", x => x.id_utilizador);
                });

            migrationBuilder.CreateTable(
                name: "Verificacao",
                columns: table => new
                {
                    id_verificacao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_utilizador = table.Column<int>(nullable: false),
                    telemovel = table.Column<string>(nullable: true),
                    nif = table.Column<int>(nullable: false),
                    num_cc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verificacao", x => x.id_verificacao);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anuncio");

            migrationBuilder.DropTable(
                name: "Faturacao");

            migrationBuilder.DropTable(
                name: "Guardado");

            migrationBuilder.DropTable(
                name: "Mensagem");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Transacoes");

            migrationBuilder.DropTable(
                name: "Utilizador");

            migrationBuilder.DropTable(
                name: "Verificacao");
        }
    }
}
