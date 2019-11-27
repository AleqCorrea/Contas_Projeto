-- phpMyAdmin SQL Dump
-- version 4.0.4.2
-- http://www.phpmyadmin.net
--
-- Máquina: localhost
-- Data de Criação: 27-Nov-2019 às 00:31
-- Versão do servidor: 5.6.13
-- versão do PHP: 5.4.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de Dados: `loja`
--
CREATE DATABASE IF NOT EXISTS `loja` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `loja`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `categoria`
--

CREATE TABLE IF NOT EXISTS `categoria` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Extraindo dados da tabela `categoria`
--

INSERT INTO `categoria` (`id`, `nome`) VALUES
(1, 'LIMPEZA'),
(2, 'padaria'),
(3, 'bebidas'),
(4, 'frutas');

-- --------------------------------------------------------

--
-- Estrutura da tabela `foto`
--

CREATE TABLE IF NOT EXISTS `foto` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_produto` int(11) DEFAULT NULL,
  `foto` varchar(120) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_produto` (`id_produto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

CREATE TABLE IF NOT EXISTS `produto` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `descricao` longtext,
  `valor` decimal(10,2) DEFAULT NULL,
  `fabricante` varchar(100) DEFAULT NULL,
  `id_categoria` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_categoria` (`id_categoria`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=50 ;

--
-- Extraindo dados da tabela `produto`
--

INSERT INTO `produto` (`id`, `nome`, `descricao`, `valor`, `fabricante`, `id_categoria`) VALUES
(1, 'coca cola 2L', 'Coca Cola 2 Litros ', '6.99', 'Coca Cola Inc', 3),
(2, 'Suco Del Valle 600ml', 'Produtor de 60% da safra de laranja no mundo, o Brasil Ã© referÃªncia quando o assunto Ã© produzir o suco da fruta. O suco Del Valle de Laranja Ã© exemplo dessa histÃ³ria. Garanta logo a sua dose certa de Vitamina C! Garrafa Del Valle de 900ml!', '3.50', 'Del Valle', 3),
(3, 'ChÃ¡ Verde LeÃ£o Sabor LimÃ£o Zero 900ml', 'Rotina livre de excessos e saudÃ¡vel. O chÃ¡ LeÃ£o Reequilibra contÃ©m antioxidantes que ajudam a neutralizar os radicais livres do organismo. O chÃ¡ verde da LeÃ£o tambÃ©m Ã© ZERO caloria, sem conservantes e rico em vitamina C. Saboreie! Adquira as 6 unidades de 900ml no sabor limÃ£o!\r\n\r\n', '5.00', 'LeÃ£o', 3),
(4, 'Ades MaÃ§Ã£ 1L', 'Ades de MaÃ§Ã£ 1L Ã© uma bebida a base de soja com suco de maÃ§a e o gostinho irresistÃ­vel dessa fruta.', '5.00', 'Ades', 3),
(5, 'Coca Cola CafÃ© 220ml', 'Coca Cola CafÃ© 220ml', '3.10', 'Coca Cola Inc', 3),
(6, 'Suco Vermelho Del Valle 300ml', 'Suco Vermelho Del Valle 300ml', '6.50', 'Del Valle', 3),
(7, 'Schweppes TÃ´nica Sem AÃ§Ãºcar 350ml', 'Schweppes TÃ´nica Sem AÃ§Ãºcar 350ml', '4.00', 'Schweppes', 3),
(8, 'Smartwater 591ml', 'Smartwater 591ml\r\n', '3.35', 'Glaceau', 3),
(9, 'Sprite 350ml', 'Sprite 350ml', '3.50', 'Sprite', 3),
(10, 'Coca Cola Zero 300ml', 'Coca Cola Zero 300ml', '3.60', 'Coca Cola Inc', 4),
(11, 'MaÃ§Ã£', 'MaÃ§Ã£ Verde', '0.60', '...', 4),
(12, 'Banana', 'Banana Nanica', '0.30', '...', 4),
(13, 'Laranja', 'Laranja', '0.40', '...', 4),
(14, 'Uva', 'Cacho de Uva', '1.20', '...', 4),
(15, 'MelÃ¢ncia', 'MelÃ¢ncia', '5.00', '...', 4),
(16, 'Jaca', 'Jaca', '3.00', '...', 2),
(17, 'Mexerica', 'Mexerica', '0.50', '...', 2),
(18, 'Abacaxi', 'Abaxaxi', '2.60', '...', 4),
(19, 'Tomate', 'Tomate', '0.70', '...', 4),
(20, 'Kiwi', 'Kiwi', '0.80', '...', 4),
(21, 'PÃ£o FrancÃªs (kg)', 'PÃ£o FrancÃªs (kg)', '12.90', 'Padaria', 2),
(22, 'PÃ£o Sovado (kg)	', 'PÃ£o Sovado (kg)	', '6.50', 'Padaria', 2),
(23, 'PÃ£o Sovado (kg)	', 'PÃ£o Sovado (kg)	', '6.50', 'Padaria', 2),
(24, 'PÃ£o Doce (kg)	', 'PÃ£o Doce (kg)	', '12.90', 'Padaria', 2),
(25, 'PÃ£o de Forma Seven Boys	', 'PÃ£o de Forma Seven Boys	', '7.95', 'Seven Boys	', 2),
(26, 'PÃ£o de Forma Wickbold	', 'PÃ£o de Forma Wickbold	', '7.95', 'Wickbold', 2),
(27, 'Leite Longa Vida Integral ItambÃ©	', 'Leite Longa Vida Integral ItambÃ©	', '3.95', 'ItambÃ©', 2),
(28, 'Leite Longa Vida Integral CotochÃ©s	', 'Leite Longa Vida Integral CotochÃ©s	', '3.95', 'CotochÃ©s', 2),
(29, 'Manteiga ItambÃ© (500 g)	', 'Manteiga ItambÃ© (500 g)	', '19.90', 'ItambÃ©', 2),
(30, 'Margarina Qualy (500 g)	', 'Margarina Qualy (500 g)	', '6.95', 'Qualy', 2),
(31, 'Presunto (kg) SADIA', 'Presunto (kg) SADIA', '22.90', 'Sadia', 2),
(32, 'Antimofo Spray com 330ml Sanol', 'Antimofo Spray com 330ml Sanol\r\n', '21.50', 'Sanol', 1),
(33, 'SabÃ£o Liquido Primavera Tixan', 'SabÃ£o Liquido Primavera Tixan', '9.50', 'Tixan', 1),
(34, 'Pasta Limpeza de Vidro Tramontina - 200g', 'Pasta Limpeza de Vidro Tramontina - 200g', '18.10', 'Tramontina', 2),
(35, 'Liquido de Limpeza AÃ§o Tramontina - 200g', 'Liquido de Limpeza AÃ§o Tramontina - 200g', '20.90', 'Tramontina', 1),
(36, 'SabÃ£o em PÃ³ Brilhante Toque de Maciez 1Kg', 'SabÃ£o em PÃ³ Brilhante Toque de Maciez 1Kg\r\n', '6.99', 'Brilhante', 1),
(37, 'SabÃ£o em Liquido Omo MultiaÃ§Ã£o 5L', 'SabÃ£o em Liquido Omo MultiaÃ§Ã£o 5L', '54.99', 'Omo', 1),
(38, 'SabÃ£o em PÃ³ Omo Lavagem Perfeita 800g', 'SabÃ£o em PÃ³ Omo Lavagem Perfeita 800g', '11.49', 'Omo', 2),
(39, 'Papel HigiÃªnico Folha Tripla Supreme', 'Papel HigiÃªnico Folha Tripla Supreme', '26.39', 'Neve', 1),
(40, 'Agua SanitÃ¡ria Carrefour 2L', 'Agua SanitÃ¡ria Carrefour 2L', '3.99', 'Carrefour', 1);

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `foto`
--
ALTER TABLE `foto`
  ADD CONSTRAINT `foto_ibfk_1` FOREIGN KEY (`id_produto`) REFERENCES `produto` (`id`);

--
-- Limitadores para a tabela `produto`
--
ALTER TABLE `produto`
  ADD CONSTRAINT `produto_ibfk_1` FOREIGN KEY (`id_categoria`) REFERENCES `categoria` (`id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
