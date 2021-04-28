
use std::time::{Instant};

fn main() {
    let elems_num = 20000000;

    let mut humans = Vec::<Human>::new();
    let mut boxed_humans = Vec::<Box<Human>>::new();

    let start_1 = Instant::now();
    for i in 0..elems_num {
        humans.push(Human {age: i, F1: 0, F2: 0, F3: 0, F4: 0})
    }
    let duration_1 = start_1.elapsed();

    let start_2 = Instant::now();
    for i in 0..elems_num {
        boxed_humans.push(Box::new(Human {age: i, F1: 0, F2: 0, F3: 0, F4: 0}))
    }
    let duration_2 = start_2.elapsed();

    let mut humans_ages = vec![0; elems_num as usize];  
    let mut boxed_human_ages= vec![0; elems_num as usize];

    let start_3 = Instant::now();
    for i in 0..elems_num as usize {
        humans_ages[i] = humans[i].age;
    }
    let duration_3 = start_3.elapsed();

    let start_4 = Instant::now();
    for i in 0..elems_num as usize {
        boxed_human_ages[i] = boxed_humans[i].age;
    }
    let duration_4 = start_4.elapsed();


    println!("Humans alloc: {:?}", duration_1);
    println!("Boxed Humans alloc: {:?}", duration_2);
    println!("Humans map: {:?}", duration_3);
    println!("Boxed Humans map: {:?}", duration_4);
}


struct Human {
    age: i32,
    F1: i32,
    F2: i32,
    F3: i32,
    F4: i32
}