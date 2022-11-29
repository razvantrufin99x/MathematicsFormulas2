using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsFormulas.NumberSets
{
    public class Set
    {

        //isempty
        public bool isEmpty = true;
        public bool isVoid = true;

        //universal set I
        public UniversalSet I = new UniversalSet();

        //complement A'
        public bool ComplementOfSet(ref Set B)
        {
            //a' = x apartien I sau x nu apartine a
            if (ProperSubset(ref B) == true) { return false; }
            return true;
        }
        //proper subset a c b
        public bool ProperSubset(ref Set B)
        {
            int nrOfElementsInBSet = B.Elements.Count;
            for (int i = 0; i < nrOfElementsInBSet; i++)
            {
                for (int j = 0; j < this.Elements.Count; j++)
                {
                    if (this.Elements[j] != B.Elements[i])
                    { return false; }
                }
            }
            return true;

        }
        //empty set vid
        public bool IsEmpty() { return isEmpty; }
        public bool IsVoid() { return isVoid; }

        public string Identifier = "A";

        public List<Element> Elements = new List<Element>();
        public List<int> inmdexedOrder = new List<int>();

        public bool Apartain(Element E)
        {

            for (int i = 0; i < Elements.Count; i++)
            {
                if (Elements[i].value == E.value) { return true; }

            }
            return false;
        }

        public bool NotApartain(Element E)
        {
            for (int i = 0; i < Elements.Count; i++)
            {
                if (Elements[i].value == E.value) { return false; }

            }
            return true;
        }
        public bool ASetApartainInSet(ref Set A, ref Set B)
        {
            for (int i = 0; i < A.Elements.Count; i++)
            {
                if (ApartainInSet(A.Elements[i], ref B) == false)
                {
                    return false;
                }

            }
            return true;
        }
        public bool ApartainInSet(Element E, ref Set B)
        {

            for (int i = 0; i < B.Elements.Count; i++)
            {
                if (B.Elements[i].value == E.value) { return true; }

            }
            return false;
        }
        public bool ApartainInThisSet(Element E, ref Set B)
        {

            for (int i = 0; i < this.Elements.Count; i++)
            {
                if (B.Elements[i].value == E.value) { return true; }

            }
            return false;
        }
        public bool NotApartainInSet(Element E, ref Set B)
        {
            for (int i = 0; i < B.Elements.Count; i++)
            {
                if (B.Elements[i].value == E.value) { return false; }

            }
            return true;
        }
        public bool ApartainInList(Element E, ref List<Element> B)
        {

            for (int i = 0; i < B.Count; i++)
            {
                if (B[i].value == E.value) { return true; }

            }
            return false;
        }

        public bool NotApartainInList(Element E, ref List<Element> B)
        {
            for (int i = 0; i < B.Count; i++)
            {
                if (B[i].value == E.value) { return false; }

            }
            return true;
        }

        public int Lenght()
        {
            return this.Elements.Count;
        }

        public bool Empty()
        {
            //vid c a
            if (this.Elements.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Set Subset(ref Set S)
        {
            Set R = new Set();
            for (int i = 0; i < S.Elements.Count; i++)
            {
                if (this.ApartainInList(S.Elements[i], ref Elements) == false)
                {
                    R.Elements.Add(this.Elements[i]);
                }

            }
            return R;
        }
        public bool IsSubset(ref Set S)
        {

            for (int i = 0; i < S.Elements.Count; i++)
            {
                if (this.ApartainInList(S.Elements[i], ref Elements) == false)
                {
                    return false;
                }

            }
            return true;
        }

        public void Union(ref Set B, ref Set R)
        {
            //daca x pentru x apartine A or x apartine B then c = a u b 
            CopyAll(ref R);
            for (int i = 0; i < B.Elements.Count; i++)
            {
                if (this.ApartainInSet(B.Elements[i], ref R) == false)
                {
                    R.Elements.Add(B.Elements[i]);
                }
            }
        }
        public void UnionOfSets(ref Set A, ref Set B, ref Set R)
        {
            //daca x pentru x apartine A or x apartine B then c = a u b 
            CopyAll(ref R);
            for (int i = 0; i < B.Elements.Count; i++)
            {
                if (this.ApartainInSet(B.Elements[i], ref R) == false)
                {
                    R.Elements.Add(B.Elements[i]);
                }
            }
        }

        public void Intersection(ref Set B, ref Set R)
        {
            //x is in A and B
            for (int i = 0; i < this.Elements.Count; i++)
            {
                if (this.ApartainInSet(this.Elements[i], ref B) == true)
                {
                    R.Elements.Add(B.Elements[i]);
                }
            }

        }
        public void IntersectionOfSets(ref Set A, ref Set B, ref Set R)
        {
            //x is in A and B
            for (int i = 0; i < A.Elements.Count; i++)
            {
                if (this.ApartainInSet(A.Elements[i], ref B) == true)
                {
                    R.Elements.Add(B.Elements[i]);
                }
            }

        }
        public void Difference(ref Set B, ref Set R)
        {
            //x is not in A and x is not in B
            //check if x from A apartain to B and if not add it of R
            for (int i = 0; i < this.Elements.Count; i++)
            {
                if (this.ApartainInSet(this.Elements[i], ref B) == false)
                {
                    R.Elements.Add(this.Elements[i]);
                }
            }
            //check if x from B is not in this and then add it in R
            for (int i = 0; i < this.Elements.Count; i++)
            {
                if (this.ApartainInList(B.Elements[i], ref this.Elements) == false)
                {
                    R.Elements.Add(B.Elements[i]);
                }
            }

        }


        // tested
        //a c I
        //a c a
        public bool isAIncludedInI() { return true; }
        public bool isAIncludedInA() { return true; }

        public bool Included(ref Set S)
        {
            //is this Set included in S
            for (int i = 0; i < S.Elements.Count; i++)
            {
                if (this.ApartainInList(S.Elements[i], ref Elements) == false)
                {
                    return false;
                }

            }
            return true;
        }

        public bool Included(ref Set A, ref Set B)
        {
            //is  Set A included in set B
            for (int i = 0; i < B.Elements.Count; i++)
            {

                if (this.ApartainInSet(B.Elements[i], ref A) == false)
                {
                    return false;
                }


            }
            return true;
        }

        public bool Inclused(ref Set B) {
            //is  Set B inclused in set A
            for (int i = 0; i < this.Elements.Count; i++)
            {

                if (this.ApartainInThisSet(this.Elements[i], ref B) == false)
                {
                    return false;
                }


            }
            return true;

        }
        //?
        public void IncludedStrict(ref Set B) { }


        public bool Equal(ref Set A, ref Set B)
        {
            //if a inclus b and b inclus a then a = b
            //is Set A included in set B
            //is Set B included in set A
            //if true true then a==b

            if (this.ASetApartainInSet(ref B, ref A) == false)
            {
                return false;
            }
            else if (this.ASetApartainInSet(ref A, ref B) == false)
            {
                return false;
            }

            return true;
        }
        public bool Different(ref Set A, ref Set B)
        {
            //are not equals
            if (this.ASetApartainInSet(ref B, ref A) == true)
            {
                return true;
            }
            else if (this.ASetApartainInSet(ref A, ref B) == true)
            {
                return true;
            }

            return false;
        }

        public void DifferenceOfSets(ref Set A, ref Set B, ref Set R) {
            for (int i = 0; i < A.Elements.Count; i++)
            {
                if (ApartainInSet(A.Elements[i], ref B) == false)
                {
                    R.Elements.Add(A.Elements[i]);
                }
            }
            for (int i = 0; i < B.Elements.Count; i++)
            {
                if (ApartainInSet(B.Elements[i], ref A) == false)
                {
                    R.Elements.Add(B.Elements[i]);
                }
            }

        }

        public void PrintSet(ref String s)
        {
            for (int i = 0; i < this.Elements.Count; i++)
            {
                s += this.Elements[i].ToString() + ",";
            }
        }
        public void PrintSet(ref TextBox t)
        {
            for (int i = 0; i < this.Elements.Count; i++)
            {
                t.Text += this.Elements[i].ToString() + ",";
            }
        }

        //element x exist in A and B
        public void Disjoint(ref Set A, ref Set B, ref Set R) {
            this.IntersectionOfSets(ref A, ref B, ref R);

        }
        //element x exist in A or B
        public void Conjoint(ref Set A, ref Set B, ref Set R) {
            this.UnionOfSets(ref A, ref B, ref R);
        }

        public void CartezianProduct(ref Set B, ref Set R, ref List<Pair> LPR)
        {
            //c = a x b = (x,y) if x apartine a and y aprtine b
            for (int i = 0; i < this.Elements.Count; i++)
            {
                for (int j = 0; j < B.Elements.Count; j++)
                {
                    LPR.Add(new Pair(this.Elements[i].value, B.Elements[j].value));

                }
            }
            for (int i = 0; i < B.Elements.Count; i++)
            {
                for (int j = 0; j < this.Elements.Count; j++)
                {
                    LPR.Add(new Pair(B.Elements[i].value, this.Elements[j].value));

                }
            }
        }
        public void CartezianProduct(ref Set A, ref Set B, ref Set R, ref List<Pair> LPR)
        {
            //c = a x b = (x,y) if x apartine a and y aprtine b
            for (int i = 0; i < A.Elements.Count; i++)
            {
                for (int j = 0; j < B.Elements.Count; j++)
                {
                    LPR.Add(new Pair(A.Elements[i].value, B.Elements[j].value));

                }
            }
            for (int i = 0; i < B.Elements.Count; i++)
            {
                for (int j = 0; j < A.Elements.Count; j++)
                {
                    LPR.Add(new Pair(B.Elements[i].value, A.Elements[j].value));

                }
            }
        }

        public void SetOfSubsets(ref List<Set> Subsets, ref Set R) { }
        public void SimetricDifference(ref Set B, ref Set R) { }

        //just for testing 
        public void Comutativity()
        {
            //a reunit b == b reunit a
            //a intersectat b = b intersectat a
        }
        public void ComutativityOfReuniom() { }
        public void ComutativityOfIntersection() { }

        public void Asociativity()
        {
            // a U ( b U c)=( a U b) U c
            // a intersectat (b intersectat c) = (a intersectat b) intersectat c
        }
        public void AsociativityOfReunion() { }
        public void AsociativityOfIntersection() { }

        public void IntersectionOfSets()
        {
            //c = aUb = x apartine A and x apartine B 
        }
        public void Distributivity()
        {
            //u reunit
            //n intersectat
            //a u b (b n c) = (a u b ) n ( a u c)
            //a n ( b u c ) = (a n b ) u ( a n c )
        }
        public void DistributivityOfReunionFacingIntersection() { }
        public void DistributivityOFIntersectionFacingReunion() { }


        public void Idempotency()
        {
            //a n a = a
            //a u a = a
        }


        public void IdempotencyOfReunion() { }
        public void IdempotencyOfIntersection() { }

        public void Domination()
        {
            //a n vid = vid
            //a u I = I
            //I multimea tuturor elementelor
        }

        public void DominationOfReunionUniversalSet() { }
        public void DominationOfIntersectionVoidSet() { }

        public void Identity()
        {
            //a u vid = a
            //a n i = a
        }
        public void IdentityOfVoidSet() { }
        public void IdentityOfIntersection() { }

        public void Complement()
        {
            //a' = x apartien I sau x nu apartine a
        }

        public void ComplementOfIntersectionAndUnion()
        {
            //a u a' = I
            //a n a' = vid
        }
        public void ComplementIntersection() { }
        public void ComplementReunion() { }

        public void DeMorganLaw()
        {
            //(a u b )' = a' n b'
            //(a n b )' = a' u b'
        }
        public void DeMorganLawOfReunionComplemented() { }
        public void DeMorganLawOfIntersectionComplemented() { }


        public void DifferenceOfSets()
        {
            //c = b\a = x
            //x apartine b and x nu apartine a
            // b \ A = b \ (a n b)
            //b \ a = b n a'
            // a \ a = vid
            // a \ b = a if a n b = vid
            //(a \ b) n c = (a n c)\(b n c)
            //a' = i / a

        }
        public void DifferenceOf2Sets() { }
        public void DifferenceOf2SetsResultingADifferenceFacingIntersection() { }
        public void DifferenceOfSetsResultingAnIntersectionWithComplement() { }
        public void DifferenceOfSameSetResultingVoid() { }
        public void DifferenceOfSetsResultingASetIfIntersectionResultedIsVoid() { }
        public void DifferenceOfSetsFacedByIntersectionWithASet() { }
        public void DifferenceOfSetWithUniversalSetResultingAComplementedSet() { }

        public void IsNotEmpty()
        {
            if (this.isEmpty == true)
            { this.isEmpty = false; }

        }
        public void LoadElement(Element element)
        {
            Elements.Add(element);
            this.IsNotEmpty();
        }

        public void LoadElements(ref List<Element> elements)
        {

            for (int i = 0; i < Elements.Count; i++)
            {
                Elements.Add(elements[i]);

            }
            this.IsNotEmpty();
        }
        public Element CreateElementFrom(float f)
        {
            return new Element(f);
        }

        public void LoadNumber(float n)
        {
            Elements.Add(CreateElementFrom(n));
            this.IsNotEmpty();
        }
        public void LoadN(ref List<float> ns)
        {
            for (int i = 0; i < Elements.Count; i++)
            {
                Elements.Add(CreateElementFrom(ns[i]));

            }
            this.IsNotEmpty();
        }

        public int SearchElement(Element element)
        {

            for (int i = 0; i < Elements.Count; i++)
            {
                if (Elements[i].value == element.value)
                {
                    return i;
                }

            }

            return -1;

        }

        public void Order() { 
            this.Elements.Sort();
        }
        public void Reverse() {
            this.Elements.Reverse();
        }
        public void Invert() {
            if (Elements.Count % 2 == 0)
            {
                for (int i = 0; i < Elements.Count / 2; i++)
                {
                    Element tmp = new Element();
                    tmp = this.Elements[this.Elements.Count-i];
                    this.Elements[this.Elements.Count - i] = this.Elements[i];
                    this.Elements[i] = tmp;



                }
            }
            else
            {
                for (int i = 0; i < (Elements.Count / 2)-1; i++)
                {
                    Element tmp = new Element();
                    tmp = this.Elements[this.Elements.Count - i];
                    this.Elements[this.Elements.Count - i] = this.Elements[i];
                    this.Elements[i] = tmp;




                }
            }
        }

        public void CopyAll(ref Set B)
        {
            for (int i = 0; i < B.Elements.Count; i++)
            {
                B.Elements.Add(Elements[i]);
            }
        }
        public void CopyAllSet(ref Set A, ref Set B)
        {
            for (int i = 0; i < B.Elements.Count; i++)
            {
                B.Elements.Add(A.Elements[i]);
            }
        }
        public void CopyFrom(int startposition, int N, ref Set B)
        {
            for (int i = startposition; i < startposition + N; i++)
            {
                B.Elements.Add(Elements[i]);
            }
        }



        public void DuplicateAll(int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < Elements.Count; j++)
                {
                    this.Elements.Add(this.Elements[i]);
                }
            }
        }

        public void DuplicateElement(int IndexOf)
        {
            this.Elements.Add(this.Elements[IndexOf]);
        }

        //?
        public void DuplicateListFrom() { }

        public void DeleteAll()
        {

            this.Elements.Clear();
            this.isEmpty = true;

        }
        public void DeleteFrom(int startposition, int N)
        {
            for (int i = startposition; i < startposition + N; i++)
            {
                this.Elements.Remove(Elements[i]);
            }
        }
        public void MoveAll(int Pozition)
        {
            for (int i = 0; i < this.Elements.Count; i++)
            {
                ///?
            }
        }
        public void MoveFrom(int startposition, int N, int endposition)
        {
            Element temp = new Element();
            for (int i = startposition; i < endposition - 1; i++)
            {
                temp = this.Elements[i];
                this.Elements.Add(temp);
                this.Elements.Remove(this.Elements[i]);

            }
        }

        public void InsertAtEnd(Element x)
        {
            this.Elements.Add(x);
        }
        public void InsertAt(int I, Element e)
        {
            this.Elements.Insert(I, e);
        }
        public void InsertListAt(int I, List<Element> list)
        {
            this.Elements.InsertRange(I, list);
        }
        public void InsertListAtEnd(List<Element> list)
        {
            this.Elements.InsertRange(this.Elements.Count + 1, list);
        }

        public void RemoveAt(int I)
        {
            this.Elements.Remove(this.Elements[I]);
        }
        public bool Contains(Element e) { return Elements.Contains(e); }
        public int IndexOf(Element e) { return Elements.IndexOf(e); }

        //sets of numbers
        //natural N
        //whole numbers N0
        //integers Z
        //positive integers Z+
        //negatvie integers Z-
        //rational Q
        //complex C
        //real numbers R
        //float numbers f
        //double numbers d
        //transcedental T
        //irrational I
        //imaginary im

        //counting set
        //Z = z- u 0 u Z+
        //axa nr Z N Q R C T I R

        //rational
        //repeating or terminating decimals
        //Q = x  = a/b , and a apartine Z, and b apartine Z and b <> 0

        //irrational number
        //non repeating and nonterminating decimals

        //real numbers
        //union of rational and irational R

        //complex
        //c = x + iy where x apartine R and y apartine R where i is imaginary unit

        //n c z n q n r n c

        //identitati de baza

        //additive a + 0 = a
        //additive inverse a+(-a) = 0
        //commutative of addition a+b = b+a
        //associative of addition (a+b)+c = a+(b+c)

        //substraction a - b = a+(-b)
        
        //multiplicative a * 1 = a
        //multiplicative inverse a*1/a = 1 where a <>0
        //multiplcation time 0 a * 0 = 0 

        //commutativity of multiplication a * b = b*a
        //associative of multiplication (a*b)*c = a*(b*c)
        //distributive law a(b+c) = ab+ac
        
        //divizion a/b = a*1/b

        

        public void IdentityOfAddingOfANumberWithZeroResultingTheNumber() { }
        public void IdentityOfAddingOfANumberWithTheInversedOfNumberResultingZero() { }
        public void IdentityOfAdditionOf2NumbersResultingTheSameSumOf2Numbers() { }
        public void IdentityOfAdditionOf3NumbersResultingTheSameSumOf3Numbers() { }

        public void IdentityOfDifferenceOF2NumbersResultingTheSumWithInversOfSecondNumber() { }

        public void IdentityOfMultiplicationOfANumberWithOneResultingTheNumber() { }
        public void IdentityOfMultiplicationOfANumberWithInverseofTheNumberResultingTheOneForNumberDifferentoFromZero() { }
        public void IdentityOfMultiplicationOfANumberWithZeroRezultingZero() { }

        public void ComutativityOfMultiplicationOf2NumberRezultingTheSameProduct() { }
        public void AssociativityOfMultiplicationOf3NumberRezultingTheSameProductOf3Numbers() { }
        public void DistributivityOfMultiplicationFacingAddingRezultingASumOf2Products() { }

        public void DivisionOf2NumbersRezultingAProductOfANumberWithInversOfOtherNumber() { }


        //complex numbers 1.4 section
    }
}
