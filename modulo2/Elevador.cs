using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo2
{
    class Elevador
    {
        private int _andar = 0;
        private int _numAndares;
        private int _capacidade;
        private int _carga = 0;

        public Elevador()
        {

        }

        #region [ Variables ]

        public int Andar { get { return _andar; } set { _andar = value; } }
        public int NumAndares { get { return _numAndares; } set { _numAndares = value; } }
        public int Capacidade { get { return _capacidade; } set { _capacidade = value; } }
        public int Carga { get { return _carga; } set { _carga = value; } }

        #endregion

        #region [ Methods ]

        //Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de
        //andares no prédio (os elevadores sempre começam no térreo e vazio);
        //Entra : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver
        //espaço);
        //Sai : para remover uma pessoa do elevador (só deve remover se houver alguém
        //dentro dele);
        //Sobe : para subir um andar (não deve subir se já estiver no último andar);
        //Desce : para descer um andar (não deve descer se já estiver no térreo);
        //Encapsular todos os atributos da classe (criar os métodos set e get).

        public void Entra()
        {
            if(_carga < _capacidade) _carga++;
        }

        public void Sai()
        {
            if (_carga > 0) _carga--;
        }

        public void Sobe()
        {
            if (_andar < _numAndares) _andar++;
        }

        public void Desce()
        {
            if (_andar > 0) _andar--;
        }

        #endregion

    }
}
