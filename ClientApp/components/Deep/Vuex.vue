<template>
    <div>
        <h1 v-once>{{msg}}</h1>
        <h3>Vuex will allow us to store state session data for our user</h3>
        State Value: {{getCount}}<br />
        <input type="button" @click="IncrementState()" value="Increase State">
    </div>
</template>

<script>
    import { mapGetters, mapActions } from 'vuex'
    export default {
        data() {
            return {
                msg: 'Vuex State Management'
            }
        },
        computed: mapGetters(['getCount']),
        methods: {
            ...mapActions(['increment']),
            Update: function () {
                this.msg = "test";
            },
            IncrementState: function () {
                this.increment();
            }
        }
    }
</script>

<style>
    .redCss {
        color: red;
    }
</style>
