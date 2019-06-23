/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package comparetriplets;

import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.function.*;
import java.util.regex.*;
import java.util.stream.*;
import static java.util.stream.Collectors.joining;
import static java.util.stream.Collectors.toList;

/**
 *
 * @author root
 */
public class CompareTriplets {

    // Complete the compareTriplets function below.
    static List<Integer> compareTriplets(List<Integer> a, List<Integer> b) {
        List c = new ArrayList();
        int d = 0;
        c.add(0,d); //Alice
        c.add(1,d); //Bob
        for (int i = 0; i < a.size(); i++){
            if ((a.get(i) > 1 && a.get(i) <= 100) && 
                (b.get(i) > 1 && b.get(i) <= 100)){
                if(a.get(i) > b.get(i)){
                   d = (int)c.get(0);
                   d++;
                   c.set(0,d); 
                } else if (a.get(i) < b.get(i)){
                   d = (int)c.get(1);
                   d++;
                   c.set(1,d);
                } else if (a.get(i) == b.get(i)){
                }
            }           
        }
        return c;
    }

    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(
                new InputStreamReader(System.in));
        BufferedWriter bufferedWriter = new BufferedWriter(
                new FileWriter("C:\\Users\\root\\comparetriplets.txt"));

        System.out.println("Introduzca la primera lista: ");
        List<Integer> a = Stream.of(
                bufferedReader.readLine().replaceAll("\\s+$", "").split(" "))
            .map(Integer::parseInt)
            .collect(toList());

        System.out.println("Introduzca la segunda lista: ");
        List<Integer> b = Stream.of(
                bufferedReader.readLine().replaceAll("\\s+$", "").split(" "))
            .map(Integer::parseInt)
            .collect(toList());

        List<Integer> result = compareTriplets(a, b);

        bufferedWriter.write(
            result.stream()
                .map(Object::toString)
                .collect(joining(" "))
            + "\n"
        );

        bufferedReader.close();
        bufferedWriter.close();
    }
}