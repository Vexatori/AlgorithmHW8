using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace AlgorithmHW8.UtilityClasses
{
    public class ArrayClass
    {
        private int[] _array;
        private int _size;
        private ArrayClass _arrBuf;

        public int[] Array
        {
            get => _array;
            set => _array = value;
        }

        public int Size
        {
            get => _size;
            set => _size = value;
        }

        public ArrayClass()
        {
            _size = 100;
            _array = new int[ _size ];
        }

        public ArrayClass( int size )
        {
            _size = size;
            _array = new int[ _size ];
        }

        public void SetArrFromFile( string path )
        {
            _array = File.ReadAllText( path ).Split( new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries )
                         .Select( int.Parse ).ToArray();
            _size = _array.Length;

            Buffer();
        }

        public void SetRandomArray( int from, int to )
        {
            Random rnd = new Random();
            for ( int i = 0; i < _size; i++ )
            {
                _array[ i ] = rnd.Next( from, to );
            }

            Buffer();
        }

        public void ShowArray()
        {
            foreach ( var num in _array )
            {
                Console.Write( $"{num,-5} " );
            }

            Console.WriteLine("\n");
        }

        private void Buffer()
        {
            _arrBuf = new ArrayClass(_size);
            for ( int i = 0; i < _size; i++ )
            {
                _arrBuf.Array[ i ] = _array[ i ];
            }
        }

        public void ResetArray()
        {
            _array = _arrBuf._array;
            _size = _arrBuf._size;
        }
    }
}