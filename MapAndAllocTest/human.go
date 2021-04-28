package main

import (
	"fmt"
	"time"
)

func main() {
	const Count = 20000000
	var humans []Human

	// Value types - like
	start := time.Now()
	for i := 0; i < Count; i++ {
		humans = append(humans, Human{Age: i, F1: 0, F2: 0, F3: 0, F4: 0})
	}
	elapsed := time.Since(start)

	// Reference types - like
	start1 := time.Now()
	var humans_boxed []*Human
	for i := 0; i < Count; i++ {
		var h = Human{Age: i, F1: 0, F2: 0, F3: 0, F4: 0}
		humans_boxed = append(humans_boxed, &h)
	}
	elapsed1 := time.Since(start1)

	start2 := time.Now()
	var human_ages [Count]int
	for i := 0; i < Count; i++ {
		human_ages[i] = humans[i].Age
	}
	elapsed2 := time.Since(start2)

	start3 := time.Now()
	var boxed_human_ages [Count]int
	for i := 0; i < Count; i++ {
		boxed_human_ages[i] = humans_boxed[i].Age
	}
	elapsed3 := time.Since(start3)

	fmt.Println(elapsed)
	fmt.Println(elapsed1)
	fmt.Println(elapsed2)
	fmt.Println(elapsed3)
}

type Human struct {
	Age int
	F1  int
	F2  int
	F3  int
	F4  int
}
