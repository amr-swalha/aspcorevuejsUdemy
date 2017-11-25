<template>
    <div>
        <h1>{{msg}}</h1>
        <h2>Student Info</h2>
        Student Name:{{student.name}}<br/>
        Student Age:{{student.age}}
        <button @click="UpdateName()">update name</button>
        <br/>
        3+5:{{ 3 +5 }}
        <br/>
        3>5:{{ 3 >5 }}
        <br />
        <!--<span title="{{msg}}"> some text</span>-->
    </div>
</template>

<script>
export default {
    data() {
        return {
            msg: 'Hello component msg',
            student: {
                name: 'Amr',
                age:26
            }
        }
        },
    methods: {
        UpdateName: function () {
            this.student.name = "new Name";
        }
    }
}
</script>

<style>
    h1{
        color:red;
    }
</style>
