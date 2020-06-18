using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorterMidterms
{
    class SortAlg {
        System.Windows.Forms.RichTextBox bub; //allows SortAlg class to acces the richtextboxes
        System.Windows.Forms.RichTextBox bins;
                
        public SortAlg(System.Windows.Forms.RichTextBox richBub, System.Windows.Forms.RichTextBox richBin) {
            bub = richBub;
            bins = richBin;
        }

        public void Iterator(System.Windows.Forms.RichTextBox target, int[] A, int length, int index){ //shows iteration
            target.Text +=  "\n" + "i= " + index + " ||  "; 
            for(int i= 0; i <length; i++) {
                target.Text += A[i] + " || ";
            }
            target.Text += "\n";
        }

        public void SortedText(System.Windows.Forms.RichTextBox target) {
            target.Text += "\n" + "\nIterations" + "\n--------------------------------------------------------------------";
        }

        public int[] BubblySort(int[] input) {
            int[] bubbleValue = input;
            int n = input.Length;
            SortedText(bub);
            for (int i = 1; i <= n/2; i++) {
                for (int j = i - 1; j <= n - 1 - i; j++) {
                    if (input[j] > input[j + 1]) {
                        int key = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = key;
                    }
                }
                for (int j = n - i - 1; j >= i ; j--) {
                    if (input[j] < input[j - 1]) {
                        int key = input[j];
                        input[j] = input[j - 1];
                        input[j - 1] = key;
                    }
                }
                Iterator(bub, input, n, i);
            }
            return bubbleValue;
        }

        public static int BinarySearchHelper(int[] A, int low, int high, int ins) {
            if (low > high) { 
                return low;
            }
            int mid = (low + high) / 2;

            if (A[mid] == ins) {
                return mid;
            }
            else if (A[mid] < ins) {
                return BinarySearchHelper(A, mid + 1, high, ins);
            }
            else {
                return BinarySearchHelper(A, low, mid - 1, ins);
            }
        }
       public static int BinarySearch(int[] A, int high, int ins) {
            return BinarySearchHelper(A, 0, high, ins);
        }

        public int[] BInsertionSort(int[] s) {
            int[] insertionValue = s;
            SortedText(bins); 
            for (int i = 1; i <= s.Length - 1 ; i++) {
                int ins = s[i];
                int j = i - 1;
                int bin = BinarySearch(s, j, ins);
                while (j >= bin && s[j] > ins) {
                    s[j + 1] = s[j];
                    j--;
                }
                s[bin] = ins;
                Iterator(bins, s, s.Length, i);
            }
            return insertionValue;
        }
    }
}

