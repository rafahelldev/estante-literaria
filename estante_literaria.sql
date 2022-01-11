-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tempo de Geração: Abr 05, 2021 as 11:13 AM
-- Versão do Servidor: 5.1.54
-- Versão do PHP: 5.3.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Banco de Dados: `estante_literaria`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `autor`
--

CREATE TABLE IF NOT EXISTS `autor` (
  `cod_autor` int(8) NOT NULL,
  `nome` varchar(150) NOT NULL,
  `dt_nascimento` date NOT NULL,
  `descricao` varchar(150) NOT NULL,
  `dt_cadastro` datetime NOT NULL,
  PRIMARY KEY (`cod_autor`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `autor`
--

INSERT INTO `autor` (`cod_autor`, `nome`, `dt_nascimento`, `descricao`, `dt_cadastro`) VALUES
(67451177, 'DJAMILA RIBEIRO', '1980-08-01', '', '2021-03-14 17:26:44'),
(82745573, 'ANTOINE DE SAINT-EXUPÉRY', '1900-06-29', '', '2021-03-14 17:13:51');

-- --------------------------------------------------------

--
-- Estrutura da tabela `autorlivro`
--

CREATE TABLE IF NOT EXISTS `autorlivro` (
  `cod_autorlivro` int(8) NOT NULL,
  `cod_autor` int(8) NOT NULL,
  `cod_livro` int(8) NOT NULL,
  PRIMARY KEY (`cod_autorlivro`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `autorlivro`
--

INSERT INTO `autorlivro` (`cod_autorlivro`, `cod_autor`, `cod_livro`) VALUES
(62713544, 67451177, 44885145),
(86525215, 67451177, 73823873),
(17515566, 82745573, 72668775);

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE IF NOT EXISTS `cliente` (
  `nome` varchar(150) NOT NULL,
  `cpf` varchar(14) NOT NULL,
  `dt_cadastro` datetime NOT NULL,
  `dt_nascimento` date NOT NULL,
  `tel_principal` varchar(14) NOT NULL,
  `tel_reserva` varchar(14) NOT NULL,
  `email` varchar(150) NOT NULL,
  `cod_cliente` int(8) NOT NULL,
  PRIMARY KEY (`cod_cliente`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`nome`, `cpf`, `dt_cadastro`, `dt_nascimento`, `tel_principal`, `tel_reserva`, `email`, `cod_cliente`) VALUES
('BRUNO MORAIS DE LIMA', '189,528,658-23', '2021-03-14 17:58:07', '1998-06-02', '(21)95846-6258', '(  )     -', 'brunomorais.bm@outlook.com', 12488386),
('ANNA BARROS SOARES', '156,486,268-72', '2021-03-14 17:59:57', '1989-06-28', '(21)98256-4261', '(21)95623-2566', 'annabsoares@gmail.com.br', 15711614),
('CARLA ALVES DA SILVA', '165,826,696-51', '2021-03-14 18:01:13', '1994-03-19', '(21)97568-3594', '(  )     -', 'alves.carla.dasilva@gmail.com', 43485746);

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionario`
--

CREATE TABLE IF NOT EXISTS `funcionario` (
  `nome` varchar(150) NOT NULL,
  `cpf` varchar(14) NOT NULL,
  `dt_cadastro` datetime NOT NULL,
  `dt_nascimento` date NOT NULL,
  `tel_principal` varchar(14) NOT NULL,
  `tel_reserva` varchar(14) NOT NULL,
  `email` varchar(150) NOT NULL,
  `cod_funcionario` int(8) NOT NULL,
  `status` varchar(100) NOT NULL,
  `cargo` varchar(150) NOT NULL,
  `turno` varchar(100) NOT NULL,
  `salario` decimal(10,0) NOT NULL,
  `cidade` varchar(150) NOT NULL,
  `bairro` varchar(150) NOT NULL,
  `cep` varchar(9) NOT NULL,
  `rua` varchar(150) NOT NULL,
  `numero` int(11) NOT NULL,
  `complemento` varchar(150) NOT NULL,
  `chave_acesso` varchar(8) NOT NULL,
  `dt_admissao` date NOT NULL,
  `dt_desligamento` date NOT NULL,
  PRIMARY KEY (`cod_funcionario`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `funcionario`
--

INSERT INTO `funcionario` (`nome`, `cpf`, `dt_cadastro`, `dt_nascimento`, `tel_principal`, `tel_reserva`, `email`, `cod_funcionario`, `status`, `cargo`, `turno`, `salario`, `cidade`, `bairro`, `cep`, `rua`, `numero`, `complemento`, `chave_acesso`, `dt_admissao`, `dt_desligamento`) VALUES
('ADM ESTANTE LITERÁRIA', '000,000,000-01', '2021-03-14 13:46:13', '0001-01-01', '(21)90000-0001', '(21)90000-0001', 'sem email', 31244323, 'FUNCIONÁRIO ATIVO', 'GERENTE', '08:00 ÀS 17:00 (INTEGRAL)', 0, 'SEM CIDADE', 'SEM BAIRRO', '10000-001', 'SEM RUA', 0, 'SEM COMPLEMENTO', 'senha123', '0001-01-01', '0001-01-01');

-- --------------------------------------------------------

--
-- Estrutura da tabela `itemvenda`
--

CREATE TABLE IF NOT EXISTS `itemvenda` (
  `cod_itemvenda` int(8) NOT NULL,
  `cod_venda` int(8) NOT NULL,
  `dt_registro` datetime NOT NULL,
  `cod_livro` int(8) NOT NULL,
  `valor_livro` decimal(10,2) NOT NULL,
  `unidades` int(11) NOT NULL,
  `valor_itemvenda` decimal(10,2) NOT NULL,
  PRIMARY KEY (`cod_itemvenda`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `itemvenda`
--

INSERT INTO `itemvenda` (`cod_itemvenda`, `cod_venda`, `dt_registro`, `cod_livro`, `valor_livro`, `unidades`, `valor_itemvenda`) VALUES
(38762216, 54861133, '2021-03-15 18:03:33', 72668775, 40.99, 4, 163.96),
(73675276, 54861133, '2021-03-15 18:03:28', 72668775, 40.99, -1, -40.99),
(88363358, 54861133, '2021-03-15 18:03:20', 72668775, 40.99, 1, 40.99),
(21622518, 54861133, '2021-03-15 18:02:39', 73823873, 40.99, 5, 204.95),
(14184414, 56411638, '2021-03-15 18:43:19', 73823873, 40.99, 2, 81.98),
(68617348, 56411638, '2021-03-15 18:41:04', 44885145, 60.24, 3, 180.72),
(18518152, 85365154, '2021-03-15 18:39:52', 72668775, 40.99, -4, -163.96),
(33861535, 85365154, '2021-03-15 18:39:46', 72668775, 40.99, 5, 204.95);

-- --------------------------------------------------------

--
-- Estrutura da tabela `livro`
--

CREATE TABLE IF NOT EXISTS `livro` (
  `cod_livro` int(8) NOT NULL,
  `titulo` varchar(150) NOT NULL,
  `ano_publicacao` int(4) NOT NULL,
  `editora` varchar(150) NOT NULL,
  `descricao` varchar(150) NOT NULL,
  `dt_cadastro` datetime NOT NULL,
  `valor_livro` decimal(10,2) NOT NULL,
  PRIMARY KEY (`cod_livro`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `livro`
--

INSERT INTO `livro` (`cod_livro`, `titulo`, `ano_publicacao`, `editora`, `descricao`, `dt_cadastro`, `valor_livro`) VALUES
(72668775, 'O PEQUENO PRINCÍPE', 1943, 'Editora Agir', 'Se trata de uma das obras literárias mais traduzidas no mundo, tendo sido publicado em mais de 220 idiomas e dialetos.', '2021-03-14 17:23:48', 40.99),
(73823873, 'PEQUENO MANUAL ANTIRRACISTA', 2019, 'COMPANHIA DAS LETRAS', '', '2021-03-14 17:29:02', 40.99),
(44885145, 'LUGAR DE FALA', 2017, 'Pólen Livros', 'Djamila Ribeiro contextualiza o indivíduo tido como universal numa sociedade cisheteropatriarcal eurocentrada.', '2021-03-14 17:34:36', 60.24);

-- --------------------------------------------------------

--
-- Estrutura da tabela `venda`
--

CREATE TABLE IF NOT EXISTS `venda` (
  `cod_venda` int(8) NOT NULL,
  `cod_cliente` int(8) NOT NULL,
  `cod_funcionario` int(8) NOT NULL,
  `dt_registro` datetime NOT NULL,
  `valor_totalvenda` decimal(10,2) NOT NULL,
  PRIMARY KEY (`cod_venda`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `venda`
--

INSERT INTO `venda` (`cod_venda`, `cod_cliente`, `cod_funcionario`, `dt_registro`, `valor_totalvenda`) VALUES
(54861133, 43485746, 31244323, '2021-03-15 18:04:11', 368.91),
(56411638, 15711614, 31244323, '2021-03-15 18:43:54', 262.70),
(85365154, 12488386, 31244323, '2021-03-15 18:40:23', 40.99);
