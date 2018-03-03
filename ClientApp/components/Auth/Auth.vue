<template>
    <div>
        <h1>{{msg}}</h1>
        <input type="text" class="form-control" v-model="email"/>
        <input type="text" class="form-control" v-model="password"/>
        <button class="btn btn-primary" @click="Login()">Generate Token</button>
        <button class="btn btn-primary" @click="CallAuthAPI()">Call APi</button>
    </div>
</template>

<script>
    import axios from 'axios'
    export default {
        data() {
            return {
                msg: 'Authentication',
                email: null,
                token:null,
                password:null
            }
        },
        methods: {
            Login: function () {
                this.$http.post('/api/Users/Login', { email: this.email, password: this.password }).then(result => {
                    this.token = result.data;
                    alert(`You are authenticated, token:${this.token}`);

                }).catch(function(error) {
                    alert("You are an Unauthorized user");
                });
            },
            CallAuthAPI: function () {
                //var config = axios.create({ headers: { 'Authorization': "Bearer " + this.token } });
                this.$http.get('/api/Users/Test', { headers: { 'Authorization': "Bearer " + this.token } }).then(result => {
                    alert(result.data);
                }).catch(function(error) {
                    alert("You are an Unauthorized user");
                });
            }
        }
    }
</script>

<style>

</style>
