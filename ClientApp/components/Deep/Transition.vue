<template>
    <div>
        <h1 v-once>{{msg}}</h1>
        <h3>Handling animations</h3>
        <p>Use the transition element</p>
        <transition name="fade" enter-active="">
            <p v-if="enableFade">Test animation</p>
        </transition>
        <button v-on:click="enableFade = !enableFade">
            Toggle
        </button>
    </div>
</template>

<script>
    
    export default {
        data() {
            return {
                msg: 'Transition and Animation',
                test: "test",
                color: 'blue',
                enableFade:true
            }
        },
        methods: {
            Update: function () {
                this.msg = "test";
            }
        }
    }
</script>

<style>
    .fade-enter-active, .fade-leave-active {
        transition: opacity .5s;
        color:blue;
    }
    .fade-enter, .fade-leave-to {
        opacity: 0;
        color:orange;
    }
</style>
