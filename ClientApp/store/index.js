import Vue from 'vue';
import Vuex from 'vuex';
Vue.use(Vuex);
export const store = new Vuex.Store({
    state: {
        count: 5
    },
    mutations: {
        increment(state) {
            state.count++;
        }
    },
    getters: {
        getCount: state => {
            return state.count;
        }
    },
    actions: {
        increment: ({ commit }) => commit('increment')
    }
});
