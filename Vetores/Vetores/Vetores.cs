using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Vetores
{
    class Vetores
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }

        public Vetores(float x,float y,float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void Altera(Vetores v)
        {
            x = v.x;
            y = v.y;
            z = v.z;
        }
        
        public void somaVetores(Vetores v)
        {
            this.x += v.x;
            this.y += v.y;
            this.z += v.z;
        }
        public void subtraiVetores(Vetores v)
        {
            this.x -= v.x;
            this.y -= v.y;
            this.z -= v.z;
        }

        public Vetores multPorEscalar(float m)
        {
            this.x *= m;
            this.y *= m;
            this.z *= m;
            return this;
        }

        public float produtoEscalar(Vetores v2)
        {
            return ((x * v2.x) + (y * v2.y) + (z * v2.z));

        }
        public float vetorUnitario()
        {
            Vetores v2 = new Vetores(x, y, z);
            v2.x = v2.x / comprimentoVetor();
            v2.y = v2.y / comprimentoVetor();
            v2.z = v2.z / comprimentoVetor();
            return v2.comprimentoVetor();
        }

        public Vetores produtoVetorial(Vetores v)
        {
            Vetores v2,v3,resultado;
            float vx, vy, vz;
            vx = this.y * v.z;
            vy = this.z * v.x;
            vz = this.x * v.y;
            v2 = new Vetores(vx, vy, vz);
            vz = this.y * v.x;
            vx = this.z * v.y;
            vy = this.x * v.z;
            v3 = new Vetores(vx, vy, vz);

            resultado = new Vetores(v2.x - v3.x, v2.y - v3.y, v2.z - v3.z);
            return resultado;

        }

        public float comprimentoVetor()
        {
            return MathF.Sqrt(x*x+y*y+z*z);
        }

        public float anguloEntreVetores(Vetores v)
        {
            float angulo;
            Vetores aux;
            aux = this;
            float resuslt1;
            resuslt1 = aux.produtoEscalar(v);
            float result2 = aux.comprimentoVetor();
            float result3 = v.comprimentoVetor();
            result2 = result2 * result3;
            angulo = MathF.Acos(resuslt1 / result2);
            return angulo;

        }

        public Vetores vetorProjecao(Vetores v)
        {
            Vetores resposta = this;
            float produtoEscalar1;
            float produtoEscalar2;
            produtoEscalar1 = this.produtoEscalar(v);
            produtoEscalar2 = this.produtoEscalar(this);
            float razao = produtoEscalar1 / produtoEscalar2;

            resposta.multPorEscalar(razao);
            return resposta;

        }

        
    }
}
