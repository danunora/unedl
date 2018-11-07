package com.dnunora;

public class Main {
    public static void main(String[] args) {

        CountDown countdown = new CountDown();

        CountDownThread t1 = new CountDownThread(countdown);
        t1.setName("THREAD1");
        CountDownThread t2 = new CountDownThread(countdown);
        t2.setName("THREAD2");
        CountDownThread t3 = new CountDownThread(countdown);
        t3.setName("THREAD3");
        t1.start();
        t2.start();
        t3.start();
    }

    static class CountDown{
        private int i;                    // instance or heap variable
        public void doCountDown(){
            String color;

            switch (Thread.currentThread().getName()){
                case "THREAD1":
                    color = ThreadColor.ANSI_RED;
                    break;
                case "THREAD2":
                    color = ThreadColor.ANSI_PURPLE;
                    break;
                    default:
                        color = ThreadColor.ANSI_GREEN;
            }

            for ( i = 10; i > 0; i--){    // int i, local or stack variable
                System.out.println(color + Thread.currentThread().getName() + ": i =" + i);
            }
        }
    }

    static class CountDownThread extends Thread{
        private CountDown threadCountDown;

        public CountDownThread(CountDown countdown){
            threadCountDown = countdown;
        }

        public void run() {
            threadCountDown.doCountDown();
        }
    }
}
