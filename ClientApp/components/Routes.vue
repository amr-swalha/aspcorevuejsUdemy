<template>
    <div>
        <h1>{{msg}}</h1>
        <h3>Parent Route Component</h3>
       Your current route is: {{RouteValue}}
        <br /> <a href="Routes/Child/5">Go to child</a>
        <router-view></router-view>
    </div>
</template>

<script>
    export default {
        data() {
            return {
                msg: 'Routes',
                RouteValue:''
               
            }
        },
        methods: {

        },
        created: function () {
            this.RouteValue = this.$route.path;
        }
    }
</script>

<style>
</style>
